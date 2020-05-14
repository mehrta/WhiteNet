using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Net;

namespace Test
{
    public class NetworkCapture
    {
        public class NetworkInterface
        {
            public String Name;
            public String Description;
            public AddressGroup[] Addresses;
            public UInt32 Flags;
        }

        public class AddressGroup
        {
            public IPEndPoint IP;
            public IPEndPoint NetMask;
            public IPEndPoint Broadcast;
            public IPEndPoint Destination;

            public AddressGroup()
            {
                IP = new IPEndPoint(0, 0);
                NetMask = new IPEndPoint(0, 0);
                Broadcast = new IPEndPoint(0, 0);
                Destination = new IPEndPoint(0, 0);
            }
        }

        public static NetworkInterface[] GetAllInterfaces()
        {
            ArrayList allInterfaces = new ArrayList();
            StringBuilder errBuffer = new StringBuilder(WinPcap.PCAP_ERRBUF_SIZE);
            IntPtr pChain = IntPtr.Zero;
            Int32 findResult;


            // Find all interfaces
            findResult = WinPcap.pcap_findalldevs_ex(WinPcap.PCAP_SRC_IF_STRING, IntPtr.Zero, ref pChain, errBuffer);

            //
            // Traverse linked list and get network interfaces
            //
            IntPtr pInterface = pChain;
            WinPcap.pcap_if_t i;
            NetworkInterface netInterface;
            WinPcap.pcap_addr pcapAddr;
            WinPcap.sockaddr sockAddr;
            ArrayList addresses = new ArrayList();

            while ((Int32)pInterface != 0)
            {
                i = (WinPcap.pcap_if_t)Marshal.PtrToStructure(pInterface, typeof(WinPcap.pcap_if_t));
                
                netInterface = new NetworkInterface();
                netInterface.Name = i.Name;
                netInterface.Description = i.Description;

                #region Get all addresses of the interface
                IntPtr pAddr;
                AddressGroup addrGroup;

                addresses.Clear();
                pAddr = i.addresses;
                
                while((Int32)pAddr != 0)
                {
                    pcapAddr = (WinPcap.pcap_addr)Marshal.PtrToStructure(pAddr, typeof(WinPcap.pcap_addr));
                    addrGroup = new AddressGroup();

                    // IP
                    if ((Int32)pcapAddr.addr != 0)
                    {
                        sockAddr = (WinPcap.sockaddr)Marshal.PtrToStructure(pcapAddr.addr, typeof(WinPcap.sockaddr));
                        addrGroup.IP.Address = new IPAddress(sockAddr.addr);
                        addrGroup.IP.Port = sockAddr.port;
                    }

                    // Subnet Mask
                    if ((Int32)pcapAddr.netmask != 0)
                    {
                        sockAddr = (WinPcap.sockaddr)Marshal.PtrToStructure(pcapAddr.netmask, typeof(WinPcap.sockaddr));
                        addrGroup.NetMask.Address = new IPAddress(sockAddr.addr);
                        addrGroup.NetMask.Port = sockAddr.port;
                    }

                    // Broadcast Address
                    if ((Int32)pcapAddr.broadaddr != 0)
                    {
                        sockAddr = (WinPcap.sockaddr)Marshal.PtrToStructure(pcapAddr.broadaddr, typeof(WinPcap.sockaddr));
                        addrGroup.Broadcast.Address = new IPAddress(sockAddr.addr);
                        addrGroup.Broadcast.Port = sockAddr.port;
                    }

                    // Destination Address
                    if ((Int32)pcapAddr.dstaddr != 0)
                    {
                        sockAddr = (WinPcap.sockaddr)Marshal.PtrToStructure(pcapAddr.dstaddr, typeof(WinPcap.sockaddr));
                        addrGroup.Destination.Address = new IPAddress(sockAddr.addr);
                        addrGroup.Destination.Port = sockAddr.port;
                    }

                    addresses.Add(addrGroup);
                    pAddr = pcapAddr.next;
                }
               
                #endregion

                // Assign addresses to the network interface
                netInterface.Addresses = (AddressGroup[])addresses.ToArray(typeof(AddressGroup));
                
                // Add the Interface to the list of interfaces
                allInterfaces.Add(netInterface);

                // Go to next network interface
                pInterface = i.Next;
            }
            
            //
            // Clean up, return
            //
            WinPcap.pcap_freealldevs(pChain);
            return (NetworkInterface[])allInterfaces.ToArray(typeof(NetworkInterface));
        }
    }

}
