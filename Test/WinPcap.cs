using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Net;

namespace Test
{
    class WinPcap
    {

        #region Global Constants
        public const string PCAP_SRC_IF_STRING = "rpcap://";   //#define PCAP_SRC_IF_STRING "rpcap://"
        public const int    PCAP_ERRBUF_SIZE = 256;            // #define PCAP_ERRBUF_SIZE   256
        public const int PCAP_OPENFLAG_PROMISCUOUS = 1;
        #endregion

        #region Global Structures

        [StructLayout( LayoutKind.Sequential)]
        public class pcap_if_t
        {
            public IntPtr Next;        // (UnManaged: struct pcap_if *next;)
            public String Name;        // (UnManaged: char *name;)
            public String Description; // (UnManaged: char *Description;)
            public IntPtr addresses;   // (UnManaged: struct pcap_addr *addresses;)
            public UInt32 Flags;       // (UnManaged: u_int flags;)
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct pcap_addr
        {
            public IntPtr next;        // (UnManaged: struct pcap_addr *next;)
            public IntPtr addr;        // (UnManaged: struct sockaddr *addr;)
            public IntPtr netmask;     // (struct sockaddr *netmask;)
            public IntPtr broadaddr;   // (struct sockaddr *broadaddr;)
            public IntPtr dstaddr;     // (struct sockaddr *dstaddr;)
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct sockaddr
        {
            public short family;
            public ushort port;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] addr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] zero;
        }


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct timeval
        {
            public System.UInt32 tv_sec; // sec
            public System.UInt32 tv_usec; // microsec
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct pcap_pkthdr
        {
            public timeval ts;
            public System.UInt32 caplen;
            public System.UInt32 len;
        }
        #endregion

        #region External Functions
        //
        // int pcap_findalldevs_ex (char *source, struct pcap_rmtauth * auth, pcap_if_t ** alldevs, char *errbuf)
        //
        [DllImport("wpcap.dll")]
        public static extern int pcap_findalldevs_ex(String source, IntPtr auth, ref IntPtr alldevs, StringBuilder errbuf);

        //
        // void pcap_freealldevs(pcap_if_t *alldevsp)
        //
        [DllImport("wpcap.dll")]
        public static extern void pcap_freealldevs(IntPtr alldevsp);

        //
        // pcap_t* pcap_open(const char *source, int snaplen, int flags, int read_timeout, struct pcap_rmtauth *auth, char *errbuf)
        //
        [DllImport("wpcap.dll")]
        public static extern IntPtr pcap_open(string source, int snaplen, int flags, int read_timeout, IntPtr auth, StringBuilder errbuf);

        //
        // int pcap_next_ex (pcap_t * p, struct pcap_pkthdr ** pkt_header, const u_char ** pkt_data)
        //
        [DllImport("wpcap.dll")]
        public static extern int pcap_next_ex(IntPtr p, ref IntPtr pkt_header, ref IntPtr packetdata);

        #endregion
    }
}
