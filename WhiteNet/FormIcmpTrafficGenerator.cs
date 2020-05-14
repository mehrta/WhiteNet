using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace WhiteNet
{
    public partial class FormIcmpTrafficGenerator : Form
    {
        private delegate void Del();
        private IcmpTrafficGenerator _icmp = new IcmpTrafficGenerator();
        private Int32 _executeDuration;
        private Int32 _elapsedTime;
        public FormIcmpTrafficGenerator()
        {
            InitializeComponent();
            _icmp.SendFinished += new IcmpTrafficGenerator.SendFinishedEventHandler(_udp_OnSendFinished);
            _icmp.TerminationMode = IcmpTrafficGenerator.TerminationCriteria.Data;
        }

        private void FormUDPTrafficGenerator_Load(object sender, EventArgs e)
        {
            cmbDataSizeUnit.SelectedIndex = 0;
            cmbTimeUnit.SelectedIndex = 0;
            cmbPayloadSizeUnit.SelectedIndex = 1;
            cmbPayloadSizeUnit.SelectedIndex = 1;
            cmbSentDataUnit.SelectedIndex = 0;
        }

        private void radTerminationcriteria_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radSender = (RadioButton)sender;
            if (!radSender.Enabled)
                return;

            if (radSender == radTerminationCriteria_None)
            {
                _icmp.TerminationMode = IcmpTrafficGenerator.TerminationCriteria.None;
                numDataUnitsToSend.Enabled =
                    cmbDataSizeUnit.Enabled =
                    lbl_Static1.Enabled =
                    numExecuteDuration.Enabled =
                    cmbTimeUnit.Enabled = false;
            }
            else if (radSender == radTerminationCriteria_Data)
            {
                _icmp.TerminationMode = IcmpTrafficGenerator.TerminationCriteria.Data;
                numExecuteDuration.Enabled =
                    cmbTimeUnit.Enabled = false;

                numDataUnitsToSend.Enabled =
                    cmbDataSizeUnit.Enabled =
                    lbl_Static1.Enabled = true;
            }
            else
            {
                _icmp.TerminationMode = IcmpTrafficGenerator.TerminationCriteria.Time;
                numExecuteDuration.Enabled =
                    cmbTimeUnit.Enabled = true;

                numDataUnitsToSend.Enabled =
                    cmbDataSizeUnit.Enabled =
                    lbl_Static1.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Change some UI elements properties
            grpDestination.Enabled =
            grpTerminationCriteria.Enabled =
            grpSettings.Enabled =
            btnClose.Enabled =
            btnStart.Enabled = false;
            btnStop.Enabled = true;

            lblTotalSentPackets.Text = "0";
            lblTotalReplies.Text = "0";
            lblLostPackets.Text = "0";
            lblLossRate.Text = "0";
            lblAvrageRtt.Text = "0";
            lblSentData.Text = "0";
            lblRecivedData.Text = "0";
            lblElapsedTime.Text = "0";
            lblTotalErrors.Text = "0";


            // Initial IcmpTrafficGenerator Object
            _icmp.HostNameOrAddress = txtHost.Text;
            _icmp.NumberOfConnections = (Int32)numNumberOfConnections.Value;
            _icmp.PayloadSize = (cmbPayloadSizeUnit.SelectedIndex == 0) ? (UInt32)numPayloadSize.Value : ((UInt32)numPayloadSize.Value * 1024);
            _icmp.ReplyTimeout = ((Int32)numReplyTimeout.Value) * 1000;
            _icmp.IpTtlField = (Int32)numIpTimeToLive.Value;
            _icmp.MaxErrors = (Int32)numMaxErrors.Value;
            _icmp.DontFragmentIpPacket = chkDontFragment.Enabled;

            if (_icmp.TerminationMode == IcmpTrafficGenerator.TerminationCriteria.Data)
                switch (cmbDataSizeUnit.SelectedIndex)
                {
                    case 0: // Unit: ICMP Packet
                        _icmp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * _icmp.PayloadSize;
                        break;
                    case 1:// Unit: Byte
                        _icmp.TotalBytesToSend = (UInt64)numDataUnitsToSend.Value;
                        break;
                    case 2:// Unit: Kilobyte
                        _icmp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * 1024;
                        break;
                    case 3:// Unit: Megabyte
                        _icmp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * 1024 * 1024;
                        break;
                    case 4:// Unit: Gigabyte
                        _icmp.TotalBytesToSend = ((UInt64)numDataUnitsToSend.Value) * 1024 * 1024 * 1024;
                        break;
                }
            //

            // Add rows to dgvStatistics
            dgvStatistics.Rows.Clear();
            for (int i = 0; i < _icmp.NumberOfConnections; i++)
                dgvStatistics.Rows.Add((i + 1).ToString(), "0", "0", "0", "0", "0");
            //

            // Start Sending ICMP packets
            _icmp.Start();

            // Enable Timer to show statistical informaton
            timStatistics.Enabled = true;
            _elapsedTime = 0;
            _executeDuration = (cmbTimeUnit.SelectedIndex == 0) ? (Int32)numExecuteDuration.Value : (Int32)numExecuteDuration.Value * 60;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Change some UI elements properties
            grpDestination.Enabled =
                grpTerminationCriteria.Enabled =
                grpSettings.Enabled =
                btnClose.Enabled =
                btnStart.Enabled = true;
            btnStop.Enabled = false;

            // disable timer
            timStatistics.Enabled = false;

            // Stop Sending Data
            _icmp.Stop();
        }

        private void timStatistics_Tick(object sender, EventArgs e)
        {
            UpdateStatistics();
            _elapsedTime += (timStatistics.Interval / 1000);
            lblElapsedTime.Text = _elapsedTime.ToString();

            // It's time to stop?
            if (_icmp.TerminationMode == IcmpTrafficGenerator.TerminationCriteria.Time && _elapsedTime >= _executeDuration)
                btnStop_Click(null, null);
        }

        private void UpdateStatistics()
        {
            UInt64 totalSentIcmpPackets = 0;
            UInt64 totalReplies = 0;
            UInt64 totalLostPackets = 0;
            Int32 totalErrors = 0;
            UInt64 totalRttSum = 0;

            // Update DataGridView
            lock (_icmp.SyncLock)
            {
                for (int i = 0; i < _icmp.NumberOfConnections; i++)
                {
                    dgvStatistics.Rows[i].Cells[1].Value = _icmp.SendStatistics[i].SentPackets.ToString();
                    dgvStatistics.Rows[i].Cells[2].Value = _icmp.SendStatistics[i].Replies.ToString();
                    if (_icmp.SendStatistics[i].SentPackets > 0)
                        dgvStatistics.Rows[i].Cells[3].Value =
                            (((Double)(_icmp.SendStatistics[i].SentPackets - _icmp.SendStatistics[i].Replies) / _icmp.SendStatistics[i].SentPackets) * 100).ToString("F1") + " %";
                    else
                        dgvStatistics.Rows[i].Cells[3].Value = "?";
                    if ( _icmp.SendStatistics[i].Replies != 0)
                        dgvStatistics.Rows[i].Cells[4].Value = (_icmp.SendStatistics[i].RttSum / _icmp.SendStatistics[i].Replies).ToString();
                    else
                        dgvStatistics.Rows[i].Cells[4].Value = "?";
                    dgvStatistics.Rows[i].Cells[5].Value = _icmp.SendStatistics[i].Errors;

                    totalSentIcmpPackets += _icmp.SendStatistics[i].SentPackets;
                    totalReplies += _icmp.SendStatistics[i].Replies;
                    totalLostPackets += (_icmp.SendStatistics[i].SentPackets - _icmp.SendStatistics[i].Replies);
                    totalRttSum += _icmp.SendStatistics[i].RttSum;
                    totalErrors += _icmp.SendStatistics[i].Errors;
                }
            }

            // Update Labels 
            lblTotalSentPackets.Text = totalSentIcmpPackets.ToString();
            lblTotalReplies.Text = totalReplies.ToString();
            lblLostPackets.Text = totalLostPackets.ToString();
            if (totalSentIcmpPackets > 0)
                lblLossRate.Text = (((Double)totalLostPackets / totalSentIcmpPackets) * 100).ToString("F1") + " %";
            else
                lblLossRate.Text = "?";
            if (totalReplies != 0)
                lblAvrageRtt.Text = (totalRttSum / totalReplies).ToString();
            else
                lblAvrageRtt.Text = "?";
            switch (cmbSentDataUnit.SelectedIndex)
            {
                case 0: // Unit : KB
                    lblSentData.Text = ((Double)(totalSentIcmpPackets * _icmp.PayloadSize) / 1024).ToString("F1") + " KB";
                    lblRecivedData.Text = ((Double)_icmp.TotalRecivedBytes / 1024).ToString("F1") + " KB";
                    break;
                case 1: // Unit : MB
                    lblSentData.Text = ((Double)(totalSentIcmpPackets * _icmp.PayloadSize) / (1024*1024)).ToString("F3") + " MB";
                    lblRecivedData.Text = ((Double)_icmp.TotalRecivedBytes / (1024*1024)).ToString("F3") + " MB";
                    break;
                case 2: // Unit : GB
                    lblSentData.Text = ((Double)(totalSentIcmpPackets * _icmp.PayloadSize) / (1024*1024*1024)).ToString("F3") + " GB";
                    lblRecivedData.Text = ((Double)_icmp.TotalRecivedBytes / (1024*1024*1024)).ToString("F3") + " GB";
                    break;
            }

            lblTotalErrors.Text = totalErrors.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _udp_OnSendFinished()
        {
            Del h1 = new Del(UpdateStatistics);
            this.Invoke(h1);

            EventHandler h2 = new EventHandler(btnStop_Click);
            this.Invoke(h2, null, null);
        }

        private void FormUDPTrafficGenerator_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!btnClose.Enabled)
                e.Cancel = true;
        }

    }
}
