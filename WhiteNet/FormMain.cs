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
    public partial class FormMain : Form
    {
        public FormSplashScreen _frmSplashScreen { set; get; }
        private int _defaultNodesState = 1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initialize NetParser static class
            NetParser.MainFormDataGridView = dgvPackets;
            NetParser.MainFormTreeView = trePacket;

            // Initialize controls
            lblNumberOfInterfaces.Text = NetMonitor.DeviceList.Count.ToString();
            cmbFilter.SelectedIndex = 0;
        }

        // This method is invoked whenever a packet recieved from network interface()
        public void OnPacketArrival(SharpPcap.CaptureEventArgs e)
        {
            try
            {
                // Generate a new DataGridViewRow
                NetParser.GenerateDataGridViewRow(e);
            }
            catch
            {
                // Do nothing.
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetMonitor.StopCapture();
            _frmSplashScreen.Close();
        }

        private void mnuItem_StartCapture_Click(object sender, EventArgs e)
        {
            CaptureStatistic.Reset();
            CaptureStatistic.StartOfCapture = DateTime.Now;
            try
            {
                NetMonitor.StartCapture();
            }
            catch
            {
                return;
            }

            // Change some elements properties
            dgvPackets.Rows.Clear();
            trePacket.Nodes.Clear();
            pnlTip.Visible = false;
            lblElapsedTime.Visible = true;
            lblElpsTime.Visible = true;
            mnuItem_Options.Enabled = false;
            mnuItem_StartCapture.Enabled = false;
            mnuItem_StopCapture.Enabled = true;
            lblProgramStatus.Text = "Capturing...";
            lblProgramStatus.ForeColor = Color.Red;
            timStatistics.Enabled = true;
        }

        private void mnuItem_StopCapture_Click(object sender, EventArgs e)
        {
            NetMonitor.StopCapture();

            // Change some elements properties
            mnuItem_Options.Enabled = true;
            mnuItem_StartCapture.Enabled = true;
            mnuItem_StopCapture.Enabled = false;
            lblProgramStatus.Text = "Stopped";
            timStatistics.Enabled = false;

        }

        private void mnuItem_ClearDataGridView_Click(object sender, EventArgs e)
        {
            CaptureStatistic.Reset();
            dgvPackets.Rows.Clear();
        }

        private void dgvPackets_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPackets.Rows[e.RowIndex].Tag != null)
            {
                PacketDotNet.InternetLinkLayerPacket internetLinkLayerPacket =
                    (PacketDotNet.InternetLinkLayerPacket)dgvPackets.Rows[e.RowIndex].Tag;
                try
                {
                    NetParser.GenerateTreeViewNode(internetLinkLayerPacket, _defaultNodesState);
                }
                catch
                {
                }
            }
        }

        private void picExpandAll_MouseDown(object sender, MouseEventArgs e)
        {
            picExpandAll.Top++;
        }

        private void picExpandAll_MouseUp(object sender, MouseEventArgs e)
        {
            picExpandAll.Top--;
        }

        private void picCollapseAll_MouseUp(object sender, MouseEventArgs e)
        {
            picCollapseAll.Top++;
        }

        private void picCollapseAll_MouseDown(object sender, MouseEventArgs e)
        {
            picCollapseAll.Top--;
        }

        private void mnuItem_UdpTrafficGenerator_Click(object sender, EventArgs e)
        {
            FormUdpTrafficGenerator frmUpd = new FormUdpTrafficGenerator();
            frmUpd.Show();
        }

        private void mnuItem_IcmpTrafficGenerator_Click(object sender, EventArgs e)
        {
            FormIcmpTrafficGenerator frmUpd = new FormIcmpTrafficGenerator();
            frmUpd.Show();
        }

        private void mnuItem_NetworkInterfaces_Click(object sender, EventArgs e)
        {
            FormNetworkInterfaces frmNetInterfaces = new FormNetworkInterfaces();
            frmNetInterfaces.ShowDialog();
        }

        private void picExpandAll_Click(object sender, EventArgs e)
        {
            trePacket.ExpandAll();
        }

        private void picCollapseAll_Click(object sender, EventArgs e)
        {
            trePacket.CollapseAll();
        }

        private void picUdpTrafficGenerator_Click(object sender, EventArgs e)
        {

        }

        private void picGoToPrevious_MouseDown(object sender, MouseEventArgs e)
        {
            picGoToPrevious.Top--;
            //
            mnuItemGoToPreviousPacket_Click(null, null);
        }

        private void picGoToPrevious_MouseUp(object sender, MouseEventArgs e)
        {
            picGoToPrevious.Top++;
        }

        private void picGoToNext_MouseDown(object sender, MouseEventArgs e)
        {
            picGoToNext.Top++;
            //
            mnuItemGoToNextPacket_Click(null, null);

        }

        private void picGoToNext_MouseUp(object sender, MouseEventArgs e)
        {
            picGoToNext.Top--;
        }

        private void picUdpTrafficGenerator_MouseEnter(object sender, EventArgs e)
        {
            lblUdpTrafficGenerator.ForeColor = Color.FromArgb(70, 70, 255);
        }

        private void picUdpTrafficGenerator_MouseLeave(object sender, EventArgs e)
        {
            lblUdpTrafficGenerator.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void picIcmpTrafficGenerator_MouseEnter(object sender, EventArgs e)
        {
            lblIcmpTrafficGenerator.ForeColor = Color.FromArgb(70, 70, 255);
        }

        private void picIcmpTrafficGenerator_MouseLeave(object sender, EventArgs e)
        {
            lblIcmpTrafficGenerator.ForeColor = Color.FromArgb(128, 128, 255);
        }

        private void picDefaultNodesState_Click(object sender, EventArgs e)
        {
            switch (_defaultNodesState)
            {
                case 0:
                    picDefault_Collapse.BorderStyle = BorderStyle.None;
                    picDefault_Collapse.BackColor = Color.Transparent;
                    break;
                case 1:
                    picDefault_Expand.BorderStyle = BorderStyle.None;
                    picDefault_Expand.BackColor = Color.Transparent;
                    break;
                case 2:
                    picDefault_First.BorderStyle = BorderStyle.None;
                    picDefault_First.BackColor = Color.Transparent;
                    break;
                case 3:
                    picDefault_Second.BorderStyle = BorderStyle.None;
                    picDefault_Second.BackColor = Color.Transparent;
                    break;
                case 4:
                    picDefault_Third.BorderStyle = BorderStyle.None;
                    picDefault_Third.BackColor = Color.Transparent;
                    break;
            }

            PictureBox picSender = (PictureBox)sender;
            if (picSender == picDefault_Collapse)
            {
                picDefault_Collapse.BorderStyle = BorderStyle.FixedSingle;
                picDefault_Collapse.BackColor = Color.Gainsboro;
                _defaultNodesState = 0;
            }
            else if (picSender == picDefault_Expand)
            {
                picDefault_Expand.BorderStyle = BorderStyle.FixedSingle;
                picDefault_Expand.BackColor = Color.Gainsboro;
                _defaultNodesState = 1;

            }
            else if (picSender == picDefault_First)
            {
                picDefault_First.BorderStyle = BorderStyle.FixedSingle;
                picDefault_First.BackColor = Color.Gainsboro;
                _defaultNodesState = 2;

            }
            else if (picSender == picDefault_Second)
            {
                picDefault_Second.BorderStyle = BorderStyle.FixedSingle;
                picDefault_Second.BackColor = Color.Gainsboro;
                _defaultNodesState = 3;

            }
            else
            {
                picDefault_Third.BorderStyle = BorderStyle.FixedSingle;
                picDefault_Third.BackColor = Color.Gainsboro;
                _defaultNodesState = 4;

            }

            // Udate treeview
            if (trePacket.Nodes.Count > 0)
                dgvPackets_RowEnter(dgvPackets, new DataGridViewCellEventArgs(1, dgvPackets.SelectedRows[0].Index));
        }

        private void picApplyFilter_Click(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedText.Trim().ToLower() == "none")
                NetMonitor.Filter = "";
            else
                NetMonitor.Filter = cmbFilter.SelectedText.ToLower();
        }

        private void picApplyFilter_MouseDown(object sender, MouseEventArgs e)
        {
            picApplyFilter.Top++;
            picApplyFilter.Left++;
        }

        private void picApplyFilter_MouseUp(object sender, MouseEventArgs e)
        {
            picApplyFilter.Top--;
            picApplyFilter.Left--;
        }

        private void mnuItem_CaptureOptions_Click(object sender, EventArgs e)
        {
            FormCaptureOptions frmCaptureOptions = new FormCaptureOptions();
            frmCaptureOptions.ShowDialog();
        }

        private void mnuItem_StartCapture_EnabledChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Enabled)
            {
                btnStartCapture.Enabled = true;
            }
            else
            {
                btnStartCapture.Enabled = false;
            }
        }

        private void mnuItem_StopCapture_EnabledChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Enabled)
            {
                btnStopCapture.Enabled = true;
            }
            else
            {
                btnStopCapture.Enabled = false;
            }

        }

        private void mnuItem_Options_EnabledChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).Enabled)
            {
                btnCaptureOptions.Enabled = true;
            }
            else
            {
                btnCaptureOptions.Enabled = false;
            }

        }



        public int currentRow { get; set; }

        private void mnuItemGoToPreviousPacket_Click(object sender, EventArgs e)
        {
            if (dgvPackets.Rows.Count > 1)
                if (dgvPackets.SelectedRows[0].Index > 0)
                {
                    int currentRowIndex;
                    currentRowIndex = dgvPackets.SelectedRows[0].Index - 1;
                    dgvPackets.Rows[currentRowIndex].Selected = true;

                    DataGridViewCellEventArgs cellArgs = new DataGridViewCellEventArgs(0, currentRowIndex);
                    dgvPackets_RowEnter(dgvPackets, cellArgs);
                }
        }

        private void mnuItemGoToNextPacket_Click(object sender, EventArgs e)
        {
            if (dgvPackets.Rows.Count > 1)
                if (dgvPackets.SelectedRows[0].Index < dgvPackets.Rows.Count - 1)
                {
                    int currentRowIndex;
                    currentRowIndex = dgvPackets.SelectedRows[0].Index + 1;
                    dgvPackets.Rows[currentRowIndex].Selected = true;

                    DataGridViewCellEventArgs cellArgs = new DataGridViewCellEventArgs(0, currentRowIndex);
                    dgvPackets_RowEnter(dgvPackets, cellArgs);
                }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timStatistics_Tick(object sender, EventArgs e)
        {
            UpdateCaptureStatistics();

            // Update lblElapsedTime.Text
            TimeSpan elapsedTime;
            elapsedTime = DateTime.Now - CaptureStatistic.StartOfCapture;
            lblElapsedTime.Text = elapsedTime.Hours.ToString() + ":" + elapsedTime.Minutes.ToString() + ":" + elapsedTime.Seconds.ToString();
            //

            if (lblProgramStatus.Text == "")
                lblProgramStatus.Text = "Capturing...";
            else
                lblProgramStatus.Text = "";
        }

        private void UpdateCaptureStatistics()
        {
            lblStatArp.Text = CaptureStatistic.CapturedArp.ToString();
            lblStatGreV4.Text = CaptureStatistic.CapturedGre.ToString();
            lblStatIcmpV4.Text = CaptureStatistic.CapturedIcmpV4.ToString();
            lblStatIcmpV6.Text = CaptureStatistic.CapturedIcmpV6.ToString();
            lblStatIgmpV4.Text = CaptureStatistic.CapturedIgmp.ToString();
            lblStatIpV4.Text = CaptureStatistic.CapturedIpV4.ToString();
            lblStatIpV6.Text = CaptureStatistic.CapturedIpV6.ToString();
            lblStatTcpV4.Text = CaptureStatistic.CapturedTcpV4.ToString();
            lblStatTcpV6.Text = CaptureStatistic.CapturedTcpV6.ToString();
            lblStatUdpV4.Text = CaptureStatistic.CapturedUdpV4.ToString();
            lblStatUdpV6.Text = CaptureStatistic.CapturedUdpV6.ToString();
            lblStatTotalCapturedPackets.Text = CaptureStatistic.NumberOfCapturedPackets.ToString();
        }

        private void btnFormAbout_Click(object sender, EventArgs e)
        {
            FormAbout frmAbout = new FormAbout();
            frmAbout.MainForm = this;
            frmAbout.Show(this);
        }

        private void mnuItem_ShowToolbar_Click(object sender, EventArgs e)
        {
            tolMain.Visible =
                pnlGoto.Visible =
                pnltools.Visible =
                pnlTraffic.Visible =
                grpFilter.Visible = 
                mnuItem_ShowToolbar.Checked;
        }

        private void mnuItem_ShowStatusbar_Click(object sender, EventArgs e)
        {
            staMain.Visible = mnuItem_ShowStatusbar.Checked;
        }

        private void mnuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trePacket_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
