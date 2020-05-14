using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WhiteNet
{
    static class ProtocolColor
    {
        public static DataGridViewCellStyle TCP { set; get; }
        public static DataGridViewCellStyle UDP { set; get; }
        public static DataGridViewCellStyle ICMP { set; get; }
        public static DataGridViewCellStyle ARP { set; get; }
        public static DataGridViewCellStyle GRE { set; get; }
        public static DataGridViewCellStyle IGMP { set; get; }

        static ProtocolColor()
        {
            TCP = new DataGridViewCellStyle();
            UDP = new DataGridViewCellStyle();
            ARP = new DataGridViewCellStyle();
            GRE = new DataGridViewCellStyle();
            IGMP = new DataGridViewCellStyle();

            TCP.BackColor = Color.LightBlue;
            UDP.BackColor = Color.LightGreen;
            ARP.BackColor = Color.LightGray;
            GRE.BackColor = Color.LightPink;
            IGMP.BackColor = Color.YellowGreen;

        }
    }
}
