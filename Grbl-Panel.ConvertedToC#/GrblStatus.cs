using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Threading;
using GrblPanel.GrblIF;
namespace GrblPanel
{

	partial class GrblGui
	{
		public class GrblStatus
		{
			// A class to display status of Grbl onto the UI
			private GrblGui _gui;
				// For sending a request every x times, e.g. for Parser state request
			public timerInfo timerState;

			public GrblStatus(ref GrblGui gui)
			{
				// do setup stuff
				_gui = gui;

				_gui.prgBarQ.Maximum = Convert.ToInt16(GrblPanel.My.Settings.QBuffMaxSize);
				_gui.prgbRxBuf.Maximum = Convert.ToInt16(GrblPanel.My.Settings.RBuffMaxSize);

				timerState = new timerInfo();
				timerState.count = 0;
			}

			public bool enableStatus(bool action)
			{
				_gui.gbStatus.Enabled = action;
				if (action == true) {
					_gui.grblPort.addRcvDelegate(_gui.showGrblStatus);
				} else {
					_gui.grblPort.deleteRcvDelegate(_gui.showGrblStatus);
				}
				return true;

			}

			public void shutdown()
			{
				// Close up shop
				_gui.statusPrompt("End");

				enableStatus(false);
			}

			public class timerInfo
			{
				// An object to pass info to Timer event
				public int count;
			}
		}
		// Class GrblStatus

		//Private __statusThread As New _statusThread()

		public void statusPrompt(string operation)
		{
			TimerCallback tcb = _statusThreadProc;
			object state = 0;
			// Start/stop status probe thread
			if (operation == "Start") {
				_statusTimer = new Timer(tcb, status.timerState, 0, Convert.ToInt16(GrblPanel.My.Settings.StatusPollInterval));
			}
			if (operation == "End") {
				// if close before Connect to Grbl
				if ((_statusTimer != null)) {
					_statusTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
				}
			}
		}

		public void changeStatusRate(int newrate)
		{
			// Change the status polling rate
			_statusTimer.Change(0, newrate);
		}


		private Timer _statusTimer;
		public void _statusThreadProc(object stateInfo)
		{
			// Send a ? status request every 200ms

			// We can't poll for Parser status until Grbl stops requiring a vbLF at end of $ commands
			// This is because that results in an ok response, which messes up Gcode file send ack's!! :-(
			GrblStatus.timerInfo state = (GrblStatus.timerInfo)stateInfo;
			state.count += 1;
			if (state.count == 10) {
				state.count = 0;
				// TODO , Change Grbl command for $G grblPort.sendData("$G")     ' Ask for Parser status
			}
			if (cbStatusPollEnable.CheckState) {
				grblPort.sendData("?");
			}
		}

		//End Class
		private void btnUnlock_Click(object sender, EventArgs e)
		{
			// Send Unlock ($x) to Grbl
			grblPort.sendData("$x");
			tabCtlPosition.SelectedTab = tpWork;
			// refocus to Work tab
			btnHome.BackColor = Color.Transparent;
			// Use decided not to Home Cycle, so clear hint
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Send Reset command to Grbl
			grblPort.sendData(Strings.Chr(24));
			// ctl-X
		}

		private void btnHold_Click(object sender, EventArgs e)
		{
			// Send Reset command to Grbl
			grblPort.sendData("!");
		}

		private void btnStartResume_Click(object sender, EventArgs e)
		{
			// Send Reset command to Grbl
			grblPort.sendData("~");
		}

		private void btnStatusGetParser_Click(object sender, EventArgs e)
		{
			// Send request for Parser State, response handler picks it up and displays
			grblPort.sendData("$G");
		}

		public void showGrblStatus(string data)
		{
			// We come here from the recv_data thread so have to do this trick to cross threads
			// (http://msdn.microsoft.com/en-ca/library/ms171728(v=vs.85).aspx)

			if (this.btnReset.InvokeRequired) {
				// we need to cross thread this callback
				grblDataReceived ncb = new grblDataReceived(this.showGrblStatus);
				this.BeginInvoke(ncb, new object[] { data });
				return;
			} else {
				// TODO This needs tidying up, pre-process message to remove leading, trailing < [ , etc. so 
				// we have a clean code flow below, create a messageType variable?
				//Console.WriteLine("showGrblStatus: " + data)
				if (data[0] == Constants.vbLf | data[0] == Constants.vbCr) {
					return;
					// nothing to do
				}
				if (this.cbVerbose.Checked) {
					// Show data in the Status screen (from our own thread)
					this.lbResponses.Items.Add(data);
					// handle case where user doesn't have 
					if (this.lbResponses.Items.Count > 1) {
						this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
					}
				} else {
					// filter out <> , ok, $G, $$ response messages
					if (data.Length > 0 & !(data.First() == "<") & !(data.First() == "o") & !(data.First() == "$") & !(data.First() == "G") & !(data.First() == "[" & data.Contains("F"))) {
						// Show data in the Status screen (from our own thread)
						this.lbResponses.Items.Add(data);
						this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
					}
				}
				if (this.lbResponses.Items.Count > 100) {
					// keep the list reasonably short
					lbResponses.Items.RemoveAt(0);
					this.lbResponses.TopIndex = this.lbResponses.Items.Count - 1;
				}

				// Split out the Q and Buffer sizes
				// (Look for Buf:nn,RX:nnn)
				if ((data.Contains("Buf:"))) {
					// Lets display the values
					data = data.Remove(data.Length - 3, 3);
					// Remove the "> " at end
					var positions = Strings.Split(data, ":");
					try {
						var buffer = Strings.Split(positions[3], ",");
						var rx = Strings.Split(positions[4], ",");
						prgbRxBuf.Value = rx[0];
						prgBarQ.Value = buffer[0];
					} catch {
						// do nothing, should have Status Report mask = 15
					}
				}

				// Show status on the buttons
				// Extract status
				var status = Strings.Split(data, ",");
				// Set indicators
				//And status(0).StartsWith("<") Then
				if ((status != null)) {
					statusSetIndicators(status[0]);
				}

				// Set button states
				if (status[0] == "<Idle" | status[0] == "<Run") {
					// Clear the button lights
					this.btnUnlock.BackColor = Color.Transparent;
					this.btnHold.BackColor = Color.Transparent;
					this.btnReset.BackColor = Color.Transparent;
					this.btnStartResume.BackColor = Color.Transparent;
					this.btnStartResume.Text = "Start";
				}
				// This might become Hold later when fixed in Grbl
				if (data.StartsWith("<Queue") | data.StartsWith("<Hold")) {
					this.btnStartResume.BackColor = Color.Crimson;
					this.btnStartResume.Text = "Resume";
				}
				if (status[0] == "<Alarm") {
					this.btnUnlock.BackColor = Color.Crimson;
				}
				if (status[0] == "<Alarm" | status[0].StartsWith("ALARM")) {
					statusSetIndicators(status[0].Substring(0, 6));
					// Messy Status messages make for messy code :(
				}
				// Major problem so cancel the file
				// Let GrblGcode class handle the error
				//gcode.sendGCodeFileStop()
			}

			// Display the Parser state if that is the message type
			// we have a Parser status message
			if (data[0] == "[" & data.Contains("F")) {
				state.ProcessGCode(data);
			}

			if (data[0] == "$" & Information.IsNumeric(data[1])) {
				// we have a Grbl Settings response
				settings.FillSettings(data);
			}

		}

		private void statusSetIndicators(string status)
		{
			// Set status indicators depending on Grbl's status
			switch (status) {
				case "<Alarm":
				case "ALARM:":
				case "ALARM":
					tbCurrentStatus.BackColor = Color.Red;
					tbCurrentStatus.Text = "ALARM";
					break;
				case "<Run":
					tbCurrentStatus.BackColor = Color.LightGreen;
					tbCurrentStatus.Text = "RUN";
					break;
				case "<Idle":
					tbCurrentStatus.BackColor = Color.LightGreen;
					tbCurrentStatus.Text = "IDLE";
					break;
				case "<Check":
					tbCurrentStatus.BackColor = Color.YellowGreen;
					tbCurrentStatus.Text = "CHECK";
					break;
				case "<Queue":
					tbCurrentStatus.BackColor = Color.YellowGreen;
					tbCurrentStatus.Text = "QUEUE";
					break;
			}
		}

	}
}
// partial grblgui
