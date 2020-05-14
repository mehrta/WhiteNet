using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace WhiteNet
{
    class IcmpTrafficGenerator
    {
        public class ConnectionStatistics
        {
            public UInt64 SentPackets { set; get; }
            public UInt64 Replies { set; get; }
            public UInt64 RttSum { set; get; }
            public Int32 Errors { set; get; }
        }

        public Object SyncLock { set; get; }
        public delegate void SendFinishedEventHandler();
        public event SendFinishedEventHandler SendFinished;
        public enum TerminationCriteria { None, Data, Time }
        public String HostNameOrAddress { set; get; }
        public Int32 NumberOfConnections { set; get; }
        public UInt32 PayloadSize { set; get; }
        public Int32 ReplyTimeout { set; get; }
        public Int32 IpTtlField { set; get; }
        public Boolean DontFragmentIpPacket { set; get; }
        public TerminationCriteria TerminationMode { set; get; }
        public UInt64 TotalBytesToSend { set; get; }
        public UInt64 TotalSentBytes { set; get; }
        public UInt64 TotalRecivedBytes { set; get; }
        public Byte[] PacketPayload { set; get; }
        public ConnectionStatistics[] SendStatistics { set; get; }
        public Int32 MaxErrors { set; get; }
        private Int32 _numberOfActiveConnections;
        private UInt64 _sessionID;
        private Thread[] _threads;
        private Ping[] _pingObjects;
        private PingOptions _pingOptions;

        public IcmpTrafficGenerator()
        {
            SyncLock = new Object();
            _sessionID = 1;
            TerminationMode = TerminationCriteria.None;
            _pingOptions = new PingOptions();
        }

        public void Start()
        {
            PacketPayload = new Byte[PayloadSize];
            SendStatistics = new ConnectionStatistics[NumberOfConnections];
            _threads = new Thread[NumberOfConnections];
            _pingObjects = new Ping[NumberOfConnections];
            _numberOfActiveConnections = NumberOfConnections;
            _pingOptions.DontFragment = DontFragmentIpPacket;
            _pingOptions.Ttl = IpTtlField;

            TotalSentBytes = 0;
            TotalRecivedBytes = 0;
            if (TerminationMode != TerminationCriteria.Data)
                TotalBytesToSend = UInt64.MaxValue - PayloadSize;

            for (int i = 0; i < NumberOfConnections; i++)
            {
                SendStatistics[i] = new ConnectionStatistics();
                _pingObjects[i] = new Ping();
                _threads[i] = new Thread(SendLoop);
                _threads[i].IsBackground = true;

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
            PingReply pingReply;

            live = true;
            threadID = Int32.Parse(Thread.CurrentThread.Name);
            lock (SyncLock)
                thisSession = _sessionID;

            // Send ICMP (Ping) loop
            while (live)
            {
                try
                {
                    // Send ping and wait for reply 
                    pingReply = _pingObjects[threadID].Send(HostNameOrAddress, ReplyTimeout, PacketPayload,_pingOptions);

                    lock (SyncLock)
                    {
                        if ((thisSession == _sessionID) && (TotalSentBytes < TotalBytesToSend))
                        {
                            SendStatistics[threadID].SentPackets++;
                            TotalSentBytes += PayloadSize;
                            if (pingReply.Status == IPStatus.Success)
                            {
                                SendStatistics[threadID].Replies++;
                                TotalRecivedBytes += (UInt64)pingReply.Buffer.Length;
                                SendStatistics[threadID].RttSum += (UInt64)pingReply.RoundtripTime;
                            }
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
