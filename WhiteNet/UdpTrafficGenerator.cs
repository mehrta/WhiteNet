using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WhiteNet
{
    class UdpTrafficGenerator
    {
        public class ConnectionStatistics
        {
            public UInt64 SentDatagrams { set; get; }
            public Int32 Errors { set; get; }
        }

        public Object SyncLock { set; get; }
        public delegate void SendFinishedEventHandler();
        public event SendFinishedEventHandler SendFinished;
        public enum TerminationCriteria { None, Data, Time }
        public String HostName { set; get; }
        public Int32 Port { set; get; }
        public Int32 NumberOfConnections { set; get; }
        public UInt32 DatagramSize { set; get; }
        public TerminationCriteria TerminationMode { set; get; }
        public UInt64 TotalBytesToSend { set; get; }
        public UInt64 TotalSentBytes { set; get; }
        public Byte[] DatagramPayload { set; get; }
        public ConnectionStatistics[] SendStatistics { set; get; }
        public Int32 MaxErrors { set; get; }
        private volatile int _numberOfActiveConnections;
        private UInt64 _sessionID;
        private Thread[] _threads;
        private UdpClient[] _udpClients;

        public UdpTrafficGenerator()
        {
            SyncLock = new Object();
            _sessionID = 1;
            TerminationMode = TerminationCriteria.None;
        }

        public void Start()
        {
            DatagramPayload = new Byte[DatagramSize];
            SendStatistics = new ConnectionStatistics[NumberOfConnections];
            _threads = new Thread[NumberOfConnections];
            _udpClients = new UdpClient[NumberOfConnections];
            _numberOfActiveConnections = NumberOfConnections;
            TotalSentBytes = 0;
            if (TerminationMode != TerminationCriteria.Data)
                TotalBytesToSend = UInt64.MaxValue - DatagramSize;

            for (int i = 0; i < NumberOfConnections; i++)
            {
                SendStatistics[i] = new ConnectionStatistics();
                _udpClients[i] = new UdpClient();
                _threads[i] = new Thread(SendLoop);
                _threads[i].Name = i.ToString();
                _threads[i].Start();
            }
        }

        public void Stop()
        {
            lock (SyncLock)
            {
                _sessionID++;
            }
        }

        private void SendLoop()
        {
            Boolean live;
            UInt64 thisSession;
            Int32 threadID;

            live = true;
            threadID = Int32.Parse(Thread.CurrentThread.Name);
            lock (SyncLock)
            {
                thisSession = _sessionID;
            }

            // Initial UdpClient Object
            try
            {
                _udpClients[threadID].Connect(HostName, Port);
            }
            catch (Exception)
            {
                // Connection Should terminate, we couldn't connect to the server!
                live = false;
                lock (SyncLock)
                {
                    SendStatistics[threadID].Errors = MaxErrors;
                }
            }

            // Send UDP datagram loop
            while (live)
            {
                try
                {
                    _udpClients[threadID].Send(DatagramPayload, DatagramPayload.Length);
                    lock (SyncLock)
                    {
                        if ((thisSession == _sessionID) && (TotalSentBytes < TotalBytesToSend))
                        {
                            SendStatistics[threadID].SentDatagrams++;
                            TotalSentBytes += DatagramSize;
                        }
                        else
                        {
                            live = false;
                        }
                    }
                }
                catch (Exception)
                {
                    lock (SyncLock)
                    {
                        SendStatistics[threadID].Errors++;
                        if (SendStatistics[threadID].Errors >= MaxErrors)
                            // Connection Should terminate, 'MaxError' errors occured!
                            live = false;
                    }
                }
            }


            // We're going out of thread, we may finish sending or 'MaxErrors' errors occured in the thread.
            Boolean callSendFinished = false; // We use this variable to prevent DeadLock!
            lock (SyncLock)
            {
                _numberOfActiveConnections--;
                if ((_numberOfActiveConnections == 0) && (thisSession == _sessionID) && (SendFinished != null))
                    callSendFinished = true;
            }
            if (callSendFinished)
                SendFinished();
        }
    }
}
