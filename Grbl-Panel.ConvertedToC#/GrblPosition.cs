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
using GrblPanel.GrblIF;
namespace GrblPanel
{

	partial class GrblGui
	{
		public class GrblPosition
		{

			private GrblGui _gui;
			public GrblPosition(ref GrblGui gui)
			{
				_gui = gui;
				// For Connected events
				(My.MyProject.Forms.GrblGui.Connected) += GrblConnected;
				(_gui.settings.GrblSettingsRetrieved) += GrblSettingsRetrieved;
			}

			public void enablePosition(bool action)
			{
				_gui.gbPosition.Enabled = action;
				if (action == true) {
					_gui.grblPort.addRcvDelegate(_gui.showGrblPositions);
				} else {
					_gui.grblPort.deleteRcvDelegate(_gui.showGrblPositions);
				}
			}

			public void shutdown()
			{
				// Close up shop
				enablePosition(false);
			}

			// Handles GrblGui.Connected Event
			private void GrblConnected(string msg)
			{

				if (msg == "Connected") {
					// We are connected to Grbl so highlight need for Homing Cycle
					_gui.btnHome.BackColor = Color.Crimson;
				}
			}

			// Handles the named event
			private void GrblSettingsRetrieved()
			{
				// Settings from Grbl are now available to query
				if (_gui.settings.IsHomingEnabled == 1) {
					// Enable the Home Cycle button
					_gui.btnHome.Visible = true;
				}

			}
		}


		public void showGrblPositions(string data)
		{
			// We come here from the recv_data thread so have to do this trick to cross threads
			// (http://msdn.microsoft.com/en-ca/library/ms171728(v=vs.85).aspx)

			//Console.WriteLine("showGrblPosition: " + data)
			if (this.tbWorkX.InvokeRequired) {
				// we need to cross thread this callback
				grblDataReceived ncb = new grblDataReceived(this.showGrblPositions);
				this.BeginInvoke(ncb, new object[] { data });
				return;
			} else {
				// Show data in the Positions group (from our own thread)
				if ((data.Contains("MPos:"))) {
					// Lets display the values
					data = data.Remove(data.Length - 3, 3);
					// Remove the "> " at end
					var positions = Strings.Split(data, ":");
					var machPos = Strings.Split(positions[1], ",");
					var workPos = Strings.Split(positions[2], ",");

					tbMachX.Text = machPos[0].ToString();
					tbMachY.Text = machPos[1].ToString();
					tbMachZ.Text = machPos[2].ToString();

					tbWorkX.Text = workPos[0].ToString();
					tbWorkY.Text = workPos[1].ToString();
					tbWorkZ.Text = workPos[2].ToString();

					//Set same values into the repeater view on Offsets page
					tbOffSetsMachX.Text = machPos[0].ToString();
					tbOffSetsMachY.Text = machPos[1].ToString();
					tbOffSetsMachZ.Text = machPos[2].ToString();

				}
			}
		}

		private void btnPosition_Click(object sender, EventArgs e)
		{
			Button b = sender;
			switch ((string)b.Tag) {
				case "HomeCycle":
					// Send Home command string
					gcode.sendGCodeLine("$H");
					btnHome.BackColor = Color.Transparent;
					// In case it was crimson for inital connect
					tabCtlPosition.SelectedTab = tpWork;
					// And show them the Work tab
					break;
				case "Spcl Posn1":
					gcode.sendGCodeLine(tbSettingsSpclPosition1.Text);
					break;
				case "Spcl Posn2":
					gcode.sendGCodeLine(tbSettingsSpclPosition2.Text);
					break;
				case "ZeroXYZ":
					gcode.sendGCodeLine(tbSettingsZeroXYZCmd.Text);
					break;
			}

		}
		private void btnWorkXYZ0_Click(object sender, EventArgs e)
		{
			Button btn = sender;
			switch ((string)btn.Tag) {
				case "X":
					gcode.sendGCodeLine(GrblPanel.My.Settings.WorkX0Cmd);
					break;
				case "Y":
					gcode.sendGCodeLine(GrblPanel.My.Settings.WorkY0Cmd);
					break;
				case "Z":
					gcode.sendGCodeLine(GrblPanel.My.Settings.WorkZ0Cmd);
					break;
			}

		}

	}
}
