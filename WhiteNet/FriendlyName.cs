using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhiteNet
{
    static class FriendlyName
    {
        public static string GetFriendlyMAC(System.Net.NetworkInformation.PhysicalAddress mac)
        {
            String result, m;

            m = mac.ToString();
            result = m[0].ToString() + m[1].ToString() + " " + m[2].ToString() + m[3].ToString() + " " + m[4].ToString() + m[5].ToString() + " " +
                     m[6].ToString() + m[7].ToString() + " " + m[8].ToString() + m[9].ToString() + " " + m[10].ToString() + m[11].ToString();

            return result;
        }

        public static string BoolToNum(bool b)
        {
            return b ? "1" : "0"; 
        }

    }
}
