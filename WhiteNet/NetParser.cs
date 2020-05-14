using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WhiteNet
{
    static class NetParser
    {
        public static DataGridView MainFormDataGridView { set; get; }
        public static TreeView MainFormTreeView { set; get; }

        public static void GenerateDataGridViewRow(SharpPcap.CaptureEventArgs e)
        {
            PacketDotNet.Packet p;
            PacketDotNet.InternetLinkLayerPacket iLinkLayerPacket = null;
            String row_SourceAddress = "";
            String row_DestinationAddress = "";
            String row_Protocol = "";
            Int32 row_PacketLength = 0;
            DataGridViewCellStyle row_cellStyle = new DataGridViewCellStyle();
            String row_Time;

            // Compute the time of packet arrival
            TimeSpan timeInterval;
            timeInterval = (e.Packet.Timeval.Date.ToLocalTime() - CaptureStatistic.StartOfCapture);
            row_Time = timeInterval.Minutes.ToString() + ":" + timeInterval.Seconds.ToString() + "::" + timeInterval.Milliseconds.ToString();
            row_cellStyle.BackColor = Color.White;

            // Get PacketDotNet.Packet object
            p = PacketDotNet.Packet.ParsePacket(e.Packet.LinkLayerType, e.Packet.Data);
            CaptureStatistic.NumberOfCapturedPackets++;

            switch (e.Packet.LinkLayerType)
            {
                case PacketDotNet.LinkLayers.Ethernet:
                    #region Parse Ethernet Packets
                    PacketDotNet.EthernetPacket etherPacket = PacketDotNet.EthernetPacket.GetEncapsulated(p);
                    iLinkLayerPacket = etherPacket;

                    // Get Some Ethernet Packet's fields
                    row_PacketLength = etherPacket.Bytes.Length;
                    switch (etherPacket.Type)
                    {
                        case PacketDotNet.EthernetPacketType.IpV4:
                            CaptureStatistic.CapturedIpV4++;
                            PacketDotNet.IPv4Packet ipv4Packet = (PacketDotNet.IPv4Packet)PacketDotNet.IPv4Packet.GetEncapsulated(etherPacket);
                            row_SourceAddress = ipv4Packet.SourceAddress.ToString();
                            row_DestinationAddress = ipv4Packet.DestinationAddress.ToString();
                            row_Protocol = "IPv4/" + ipv4Packet.Protocol.ToString();
                            switch (ipv4Packet.Protocol)
                            {
                                case PacketDotNet.IPProtocolType.TCP:
                                    CaptureStatistic.CapturedTcpV4++;
                                    row_cellStyle = ProtocolColor.TCP;
                                    break;
                                case PacketDotNet.IPProtocolType.UDP:
                                    CaptureStatistic.CapturedUdpV4++;
                                    row_cellStyle = ProtocolColor.UDP;
                                    break;
                                case PacketDotNet.IPProtocolType.GRE:
                                    CaptureStatistic.CapturedGre++;
                                    row_cellStyle = ProtocolColor.GRE;
                                    break;
                                case PacketDotNet.IPProtocolType.ICMP:
                                    CaptureStatistic.CapturedIcmpV4++;
                                    row_cellStyle = ProtocolColor.ICMP;
                                    break;
                                case PacketDotNet.IPProtocolType.IGMP:
                                    CaptureStatistic.CapturedIgmp++;
                                    row_cellStyle = ProtocolColor.IGMP;
                                    break;
                            }

                            break;

                        case PacketDotNet.EthernetPacketType.IpV6:
                            CaptureStatistic.CapturedIpV6++;
                            PacketDotNet.IPv6Packet ipv6Packet = (PacketDotNet.IPv6Packet)PacketDotNet.IPv6Packet.GetEncapsulated(etherPacket);
                            row_SourceAddress = ipv6Packet.SourceAddress.ToString();
                            row_DestinationAddress = ipv6Packet.DestinationAddress.ToString();
                            row_Protocol = "IPv6/" + ipv6Packet.NextHeader.ToString();
                            switch (ipv6Packet.NextHeader)
                            {
                                case PacketDotNet.IPProtocolType.GRE:
                                    CaptureStatistic.CapturedGre++;
                                    break;
                                case PacketDotNet.IPProtocolType.ICMP:
                                    CaptureStatistic.CapturedIcmpV4++;
                                    break;
                                case PacketDotNet.IPProtocolType.ICMPV6:
                                    CaptureStatistic.CapturedIcmpV6++;
                                    break;
                                case PacketDotNet.IPProtocolType.IGMP:
                                    CaptureStatistic.CapturedIgmp++;
                                    break;
                                case PacketDotNet.IPProtocolType.TCP:
                                    CaptureStatistic.CapturedTcpV6++;
                                    break;
                                case PacketDotNet.IPProtocolType.UDP:
                                    CaptureStatistic.CapturedUdpV6++;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case PacketDotNet.EthernetPacketType.Arp:
                            CaptureStatistic.CapturedArp++;
                            row_Protocol = "ARP";
                            row_SourceAddress = etherPacket.SourceHwAddress.ToString();
                            row_DestinationAddress = "Broadcast";
                            row_cellStyle = ProtocolColor.ARP;
                            break;

                        default:
                            row_Protocol = etherPacket.Type.ToString();
                            break;
                    }
                    #endregion
                    break;
            }

            // Add packet to the DataGridVeiw
            DataGridViewRow newRow = (DataGridViewRow)MainFormDataGridView.RowTemplate.Clone();

            newRow.CreateCells(MainFormDataGridView);
            newRow.Tag = iLinkLayerPacket;
            newRow.SetValues(CaptureStatistic.NumberOfCapturedPackets, row_Time, row_SourceAddress,
                row_DestinationAddress, row_Protocol, row_PacketLength);
            foreach (DataGridViewCell cell in newRow.Cells)
                cell.Style = row_cellStyle;

            MainFormDataGridView.Rows.Add(newRow);
        }

        public static void GenerateTreeViewNode(PacketDotNet.InternetLinkLayerPacket p, Int32 NodesState)
        {
            PacketDotNet.EthernetPacket etherpacket;
            TreeNode linkLayerNode = new TreeNode();
            TreeNode networkLayerNdoe = new TreeNode();
            TreeNode transportLayerNode = new TreeNode();

            if (p is PacketDotNet.EthernetPacket)
            {
                etherpacket = (PacketDotNet.EthernetPacket)p;

                linkLayerNode.Text = "Ethernet Packet (Header Length = " + etherpacket.Bytes.Length.ToString() + " Bytes)";
                linkLayerNode.Nodes.Add("Source Address: " + FriendlyName.GetFriendlyMAC(etherpacket.SourceHwAddress));
                linkLayerNode.Nodes.Add("Destination Address: " + FriendlyName.GetFriendlyMAC(etherpacket.DestinationHwAddress));
                linkLayerNode.Nodes.Add("Payload Protocol: " + etherpacket.Type.ToString());

                //
                // Add Network Layer Node
                //
                switch (etherpacket.Type)
                {
                    case PacketDotNet.EthernetPacketType.IpV4:
                        #region IPv4
                        PacketDotNet.IPv4Packet ipv4Packet = (PacketDotNet.IPv4Packet)PacketDotNet.IPv4Packet.GetEncapsulated(etherpacket);
                        networkLayerNdoe.Text = "IPv4 Protocol";
                        networkLayerNdoe.Nodes.Add("Version: " + ipv4Packet.Version.ToString());
                        networkLayerNdoe.Nodes.Add("IHL (Header Length): " + ipv4Packet.HeaderLength.ToString());
                        networkLayerNdoe.Nodes.Add("Type Of Service: " + ipv4Packet.TypeOfService.ToString());
                        networkLayerNdoe.Nodes.Add("Total Length: " + ipv4Packet.TotalLength.ToString());
                        networkLayerNdoe.Nodes.Add("Identification: " + ipv4Packet.Id.ToString());
                        networkLayerNdoe.Nodes.Add("Fragment Flags: " + ipv4Packet.FragmentFlags.ToString());
                        networkLayerNdoe.Nodes.Add("Fragment Offset: " + ipv4Packet.FragmentOffset.ToString());
                        networkLayerNdoe.Nodes.Add("Time To Live: " + ipv4Packet.TimeToLive.ToString());
                        networkLayerNdoe.Nodes.Add("Protocol: " + ipv4Packet.Protocol.ToString());
                        networkLayerNdoe.Nodes.Add("Checksum: " + ipv4Packet.Checksum.ToString());
                        networkLayerNdoe.Nodes.Add("Source IP: " + ipv4Packet.SourceAddress.ToString());
                        networkLayerNdoe.Nodes.Add("Destination IP: " + ipv4Packet.DestinationAddress.ToString());
                        //networkLayerNdoe.Nodes.Add("Source IP: " + ipv4Packet.);

                        // Add Transport Layer Node
                        switch (ipv4Packet.Protocol)
                        {
                            case PacketDotNet.IPProtocolType.ICMP:
                                break;
                            case PacketDotNet.IPProtocolType.IGMP:
                                break;
                            case PacketDotNet.IPProtocolType.IPV6:
                                break;
                            case PacketDotNet.IPProtocolType.TCP:
                                PacketDotNet.TcpPacket tcpPacket;
                                tcpPacket = (PacketDotNet.TcpPacket)ipv4Packet.PayloadPacket;
                                transportLayerNode.Text = "TCP Datagram";
                                transportLayerNode.Nodes.Add("Source Port: " + tcpPacket.SourcePort.ToString());
                                transportLayerNode.Nodes.Add("Destination Port: " + tcpPacket.DestinationPort.ToString());
                                transportLayerNode.Nodes.Add("Sequence Number: " + tcpPacket.SequenceNumber.ToString());
                                transportLayerNode.Nodes.Add("Acknowledgment Number: " + tcpPacket.AcknowledgmentNumber.ToString());
                                transportLayerNode.Nodes.Add("DataOffset Number: " + tcpPacket.DataOffset.ToString());
                                transportLayerNode.Nodes.Add("URG: " + FriendlyName.BoolToNum(tcpPacket.Urg));
                                transportLayerNode.Nodes.Add("ACK: " + FriendlyName.BoolToNum(tcpPacket.Ack));
                                transportLayerNode.Nodes.Add("PSH: " + FriendlyName.BoolToNum(tcpPacket.Psh));
                                transportLayerNode.Nodes.Add("RST: " + FriendlyName.BoolToNum(tcpPacket.Rst));
                                transportLayerNode.Nodes.Add("SYN: " + FriendlyName.BoolToNum(tcpPacket.Syn));
                                transportLayerNode.Nodes.Add("FIN: " + FriendlyName.BoolToNum(tcpPacket.Fin));
                                transportLayerNode.Nodes.Add("Window Size: " + tcpPacket.WindowSize.ToString());
                                transportLayerNode.Nodes.Add("Checksum: " + tcpPacket.Checksum.ToString());
                                transportLayerNode.Nodes.Add("Urgent Pointer: " + tcpPacket.UrgentPointer.ToString());
                                transportLayerNode.Nodes.Add("Options: ");
                                transportLayerNode.Nodes.Add("(Payload Length: " + tcpPacket.PayloadData.Length.ToString() + ")");

                                break;
                            case PacketDotNet.IPProtocolType.UDP:
                                PacketDotNet.UdpPacket udpPacket;
                                udpPacket = (PacketDotNet.UdpPacket)ipv4Packet.PayloadPacket;
                                transportLayerNode.Text = "UDP Datagram";
                                transportLayerNode.Nodes.Add("Source Port: " + udpPacket.SourcePort.ToString());
                                transportLayerNode.Nodes.Add("Destination Port: " + udpPacket.DestinationPort.ToString());
                                transportLayerNode.Nodes.Add("Length: " + udpPacket.Length.ToString());
                                transportLayerNode.Nodes.Add("Checksum: " + udpPacket.Checksum.ToString());
                                transportLayerNode.Nodes.Add("(Payload Length: " + udpPacket.PayloadData.Length.ToString() + ")");
                                break;
                            default:
                                break;
                        }
                        #endregion
                        break;

                    case PacketDotNet.EthernetPacketType.IpV6:

                        break;
                    case PacketDotNet.EthernetPacketType.Arp:
                        PacketDotNet.ARPPacket arpPacket;
                        arpPacket = (PacketDotNet.ARPPacket)PacketDotNet.ARPPacket.GetEncapsulated(etherpacket);
                        networkLayerNdoe.Text = "ARP Packet";
                        networkLayerNdoe.Nodes.Add("Hardware Type: " + arpPacket.HardwareAddressType.ToString());
                        networkLayerNdoe.Nodes.Add("Protocol Type: " + arpPacket.ProtocolAddressType.ToString());
                        networkLayerNdoe.Nodes.Add("Hardware Address Length: " + arpPacket.HardwareAddressLength.ToString());
                        networkLayerNdoe.Nodes.Add("Protocol Address Length: " + arpPacket.ProtocolAddressLength.ToString());
                        networkLayerNdoe.Nodes.Add("Operation: " + arpPacket.Operation.ToString());
                        networkLayerNdoe.Nodes.Add("Sender Hardware Address: " + arpPacket.SenderHardwareAddress.ToString());
                        networkLayerNdoe.Nodes.Add("Sender Protocol Address: " + arpPacket.SenderProtocolAddress.ToString());
                        networkLayerNdoe.Nodes.Add("Target Hardware Address: " + arpPacket.TargetHardwareAddress.ToString());
                        networkLayerNdoe.Nodes.Add("Target Protocol Address: " + arpPacket.TargetProtocolAddress.ToString());

                        break;

                    default:
                        break;
                }

            }
            // Add Node to TreeView
            MainFormTreeView.Nodes.Clear();
            switch (NodesState)
            {
                case 1:
                    linkLayerNode.Expand();
                    networkLayerNdoe.Expand();
                    if (transportLayerNode.Nodes.Count > 0)
                        transportLayerNode.Expand();
                    break;
                case 2: // Default_first
                    linkLayerNode.Expand();
                    break;
                case 3: // Default_Second
                    networkLayerNdoe.Expand();
                    break;
                case 4: // Default_Third
                    if (transportLayerNode.Nodes.Count > 0)
                        transportLayerNode.Expand();
                    break;
            }
            MainFormTreeView.Nodes.Add(linkLayerNode);
            MainFormTreeView.Nodes.Add(networkLayerNdoe);
            if (transportLayerNode.Nodes.Count > 0)
                MainFormTreeView.Nodes.Add(transportLayerNode);
        }

    }
}
