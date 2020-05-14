using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace WhiteNet
{
    static class NetMonitor
    {
        public delegate void PacketArrival(SharpPcap.CaptureEventArgs e);
        public static FormMain MainForm;
        public static SharpPcap.CaptureDeviceList DeviceList { set; get; }
        public static SharpPcap.DeviceMode CaptureMode { set; get; }
        public static String Filter{ set; get; }
        public static Int32 ActiveDeviceIndex { set; get; }
        private static Boolean _stoppingCapture;
        private static Object _syncLock;

        static NetMonitor()
        {
            _syncLock = new Object();
        }

        public static void Initialize(SharpPcap.CaptureDeviceList d)
        {
            DeviceList = d;

            // Select default device
            ActiveDeviceIndex = 0;
        }

        public static void StartCapture()
        {
            SharpPcap.ICaptureDevice activeDevice;
            activeDevice = DeviceList[ActiveDeviceIndex];

            _stoppingCapture = false;
            activeDevice.OnPacketArrival += new SharpPcap.PacketArrivalEventHandler(Callback_OnPacketArrival);
            activeDevice.Open(NetMonitor.CaptureMode);
            activeDevice.Filter = Filter;
            activeDevice.StartCapture();
        }

        public static void StopCapture()
        {
            SharpPcap.ICaptureDevice activeDevice;
            activeDevice = DeviceList[ActiveDeviceIndex];

            lock(_syncLock)
                _stoppingCapture = true;

            try
            {
                activeDevice.StopCapture();
            }
            catch
            {
                // If an error occurred, do nothing!
            }
            finally
            {
                activeDevice.Close();
            }
        }

        public static void Callback_OnPacketArrival(object sender, SharpPcap.CaptureEventArgs e)
        {
            Boolean shouldEventHandlerCalled = true;

            lock (_syncLock)
            {
                if (_stoppingCapture)
                    shouldEventHandlerCalled = false;
            }

            if (shouldEventHandlerCalled)
            {
                // Call Event handler of FormMain (in the context of FormMain thread) 
                PacketArrival del = MainForm.OnPacketArrival;
                MainForm.Invoke(del, e);
            }
        }


    }
}
