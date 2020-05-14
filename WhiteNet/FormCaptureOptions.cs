using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhiteNet
{

    public partial class FormCaptureOptions : Form
    {
        public FormCaptureOptions()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            NetMonitor.ActiveDeviceIndex =  cboxDevicees.SelectedIndex;
            NetMonitor.CaptureMode = chkPromiscuous.Checked ? SharpPcap.DeviceMode.Promiscuous : SharpPcap.DeviceMode.Normal;
            this.Close();
        }

        private void FormCaptureOptions_Load(object sender, EventArgs e)
        {
            // Fill ComboBox with device list
            foreach (var device  in NetMonitor.DeviceList)
            {
                DeviceProperties dp = new DeviceProperties();
                
                device.Open();
                dp.LinkType = device.LinkType.ToString();
                dp.Name = device.Name;
                dp.IP = "";
                dp.Description = device.Description;
                dp.MAC = device.MacAddress.ToString();
                device.Close();
                
                cboxDevicees.Items.Add(dp);
           }

            cboxDevicees.SelectedIndex = NetMonitor.ActiveDeviceIndex;
            chkPromiscuous.Checked = NetMonitor.CaptureMode == SharpPcap.DeviceMode.Promiscuous ? true : false;
            //
        }

        private void cboxDevicees_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescription.Text = ((DeviceProperties)cboxDevicees.SelectedItem).Description;
            lblLinkType.Text = ((DeviceProperties)cboxDevicees.SelectedItem).LinkType;
            lblMAC.Text = ((DeviceProperties)cboxDevicees.SelectedItem).MAC;
        }
    }

    class DeviceProperties
    {
        public String Name {set;get;}
        public String Description;
        public String LinkType;
        public String IP;
        public String MAC;
    }
}
