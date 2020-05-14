using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhiteNet
{
    static class CaptureStatistic
    {
        public static DateTime StartOfCapture { set; get; }
        public static TimeSpan CaptureDuration { set; get; }
        public static UInt64 NumberOfCapturedPackets { set; get; }
        public static UInt64 CapturedIpV4 { set; get; }
        public static UInt64 CapturedIpV6 { set; get; }
        public static UInt64 CapturedTcpV4 { set; get; }
        public static UInt64 CapturedTcpV6 { set; get; }
        public static UInt64 CapturedUdpV4 { set; get; }
        public static UInt64 CapturedUdpV6 { set; get; }
        public static UInt64 CapturedIcmpV4 { set; get; }
        public static UInt64 CapturedIcmpV6 { set; get; }
        public static UInt64 CapturedIgmp { set; get; }
        public static UInt64 CapturedGre { set; get; }
        public static UInt64 CapturedArp { set; get; }

        public static void Reset()
        {
            NumberOfCapturedPackets = 0;
            CaptureDuration = TimeSpan.Zero;
            CapturedIpV4 = 0;
            CapturedIpV6 = 0;
            CapturedTcpV4 = 0;
            CapturedTcpV6 = 0;
            CapturedUdpV4 = 0;
            CapturedUdpV6 = 0;
            CapturedIcmpV4 = 0;
            CapturedIcmpV6 = 0;
            CapturedIgmp = 0;
            CapturedGre = 0;
            CapturedArp = 0;
        }
    }
}
