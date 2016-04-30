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
using System.Globalization;
using System.Threading;
using System.Threading.Thread;
namespace GrblPanel
{


	public partial class GrblGui
	{

			// Public so that the timer thread can see grblPort
		public GrblIF grblPort;
			// For status polling
		private GrblStatus status;
			// for jogging control
		private GrblJogging jogging;
			// for machine and work positioning
		private GrblPosition position;
			// For processing gcode file
		public static GrblGcode gcode;
			// for display of gcode
		public static GrblGcodeView gcodeview;
			// for handling of offsets
		public GrblOffsets offsets;
			// to track gcode state
		public GrblState state;
			// To handle Settings related ops
		public GrblSettings settings;

		public void myhandler(object sender, UnhandledExceptionEventArgs args)
		{
			// Show exception in usable manner
			Exception e = (Exception)args.ExceptionObject;
			MessageBox.Show("Exception: " + e.Message + Constants.vbLf + e.InnerException.Message + Constants.vbLf + e.StackTrace);
		}


		private void grblgui_Load(object sender, System.EventArgs e)
		{
			// Use handler below to trap wierd problems at Form creation, e.g. when going from .Net 4 to 3.5
			AppDomain.CurrentDomain.UnhandledException += myhandler;

			// Ensure that we always interpret things such as '.' as decimal (instead of ',' in EU)
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA");

			// Set user preferences/defaults
			Application.EnableVisualStyles();

			// Trick the Settings tab page into loading its controls so that
			// the config settings are avail to rest of program. Seems kludgy but  there is no other solution
			// if you want to use Tab pages this way. It makes sense as controls are not run until they get focus.
			tabPgSettings.Show();
			tabPgInterface.Show();

			// Are we right handed?

			SwitchSides(cbSettingsLeftHanded.Checked);

			grblPort = new GrblIF();
			settings = new GrblSettings(this);
			status = new GrblStatus(this);
			jogging = new GrblJogging(this);
			position = new GrblPosition(this);
			gcode = new GrblGcode(this);
			gcodeview = new GrblGcodeView(dgvGcode);
			offsets = new GrblOffsets(this);
			state = new GrblState(this);

			rescanPorts();
			if (!string.IsNullOrEmpty(GrblPanel.My.Settings.Port)) {
				cbPorts.SelectedIndex = cbPorts.FindStringExact(GrblPanel.My.Settings.Port);
			}

			cbBaud.SelectedText = GrblPanel.My.Settings.Baud;
			grblPort.baudrate = Convert.ToInt32(GrblPanel.My.Settings.Baud);

			tcConnection.SelectedIndex = GrblPanel.My.Settings.ConnectionType;
			tbIPAddress.Text = GrblPanel.My.Settings.IPAddress;

			if (cbSettingsConnectOnLoad.Checked) {
				// auto connect
				btnConnDisconnect_Click(btnConnect, null);
			}

			EnableMacroButtons();

			// Capture all keyboard events so that we get to see arrow keys. If we don't do this then
			// the various controls keep the arrow keys if one gets focus
			Application.AddMessageFilter(new MsgFilter(this));
		}

		private void grblgui_unload()
		{
			// TODO Is this still necessary??
			var _with1 = GrblPanel.My.Settings;
			_with1.JoggingUnitsMetric = cbUnits.Checked;
			_with1.JoggingFIImperial = tbSettingsFIImperial.Text;
			_with1.JoggingFRImperial = tbSettingsFRImperial.Text;
			_with1.JoggingFIMEtric = tbSettingsFIMetric.Text;
			_with1.JoggingFRMetric = tbSettingsFRMetric.Text;

			tidyClose();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// On the rare occasion that someone uses File/Exit
			tidyClose();
		}

		private void tidyClose()
		{
			// Close down in a tidy fashion
			grblPort.Disconnect();
			gcode.shutdown();
			status.shutdown();
			jogging.shutdown();
			position.shutdown();

			Application.Exit();
		}
		public class MsgFilter : IMessageFilter
		{
			private GrblGui _gui;
			public MsgFilter(ref GrblGui owner)
			{
				_gui = owner;
			}

			/// <summary>
			/// Handle key press overrides and keyboard mapping
			/// </summary>
			/// <param name="msg"></param>
			/// <returns>True if key msg was handled</returns>
			[DebuggerStepThrough()]
			private bool PreFilterMessage(ref Message msg)
			{
				bool handled = false;

				// We have a KeyDown event
				if (msg.Msg == 0x100) {

					if (_gui.gbJogging.Enabled & !_gui.tbSendData.ContainsFocus) {
						if (_gui.cbSettingsKeyboardJogging.Checked) {
							switch (msg.WParam) {
								// ignoring modifiers for now
								case Keys.Left:
									_gui.btnXMinus.PerformClick();
									handled = true;
									break;
								case Keys.Right:
									_gui.btnXPlus.PerformClick();
									handled = true;
									break;
								case Keys.Up:
									_gui.btnYPlus.PerformClick();
									handled = true;
									break;
								case Keys.Down:
									_gui.btnYMinus.PerformClick();
									handled = true;
									break;
								case Keys.PageUp:
									_gui.btnZPlus.PerformClick();
									handled = true;
									break;
								case Keys.PageDown:
									_gui.btnZMinus.PerformClick();
									handled = true;
									break;
							}
							if (handled) {
								return true;
							}
						}
					}

					// Non-jog mappings
					// in case user is working in MDI
					if (!_gui.tbSendData.ContainsFocus & !_gui.gbEditor.ContainsFocus) {
						switch (msg.WParam) {
							// Act on Distance Increment keyboard requests
							case Keys.Add:
								_gui.changeDistanceIncrement(true);
								handled = true;
								break;
							case Keys.Subtract:
								_gui.changeDistanceIncrement(false);
								handled = true;

								break;
							// Act on Feed Rate keyboard requests
							case Keys.Divide:
								_gui.changeFeedRate(true);
								handled = true;
								break;
							case Keys.Multiply:
								_gui.changeFeedRate(false);
								handled = true;

								break;
							// Reset x,y,z axis to 0
							case Keys.X:
								_gui.btnWorkX0.PerformClick();
								handled = true;
								break;
							case Keys.Y:
								_gui.btnWorkY0.PerformClick();
								handled = true;
								break;
							case Keys.Z:
								_gui.btnWorkZ0.PerformClick();
								handled = true;

								break;
							// Reset all axes to 0
							case Keys.Insert:
								break;
							case Keys.A:
								_gui.btnWork0.PerformClick();
								handled = true;
								break;
						}
					}
					if (handled == true) {
						return true;
					}
				}

				// We didn't handle event so pass it along
				return false;
			}

		}


		private void SwitchSides(bool side)
		{
			// We switch GUI sides

			Control ctl = null;

			// Get existing locations for X      ' Issue #17,18 and others fix
			int left_X = 0;
			int right_X = 0;
			left_X = gbJogging.Width + 3;
			right_X = gbPosition.Width + 3;

			// we are going left handed
			if (side) {
				foreach (Control ctl_loopVariable in {
					gbGrbl,
					gbJogging,
					gbGcode
				}) {
					ctl = ctl_loopVariable;
					ctl.Location = new Point(3, ctl.Location.Y);
				}
				gbMDI.Location = new Point(3 + gbGrbl.Width + 3, gbMDI.Location.Y);

				foreach (Control ctl_loopVariable in {
					gbPosition,
					gbStatus,
					gbControl
				}) {
					ctl = ctl_loopVariable;
					ctl.Location = new Point(3 + left_X, ctl.Location.Y);
				}
			} else {
				foreach (Control ctl_loopVariable in {
					gbGrbl,
					gbJogging,
					gbGcode
				}) {
					ctl = ctl_loopVariable;
					ctl.Location = new Point(3 + right_X, ctl.Location.Y);
				}
				gbMDI.Location = new Point(3 + right_X + gbGrbl.Width + 3, gbMDI.Location.Y);

				foreach (Control ctl_loopVariable in {
					gbPosition,
					gbStatus,
					gbControl
				}) {
					ctl = ctl_loopVariable;
					ctl.Location = new Point(3, ctl.Location.Y);
				}
			}

		}

		private void cbSettingsLeftHanded_CheckedChanged(object sender, EventArgs e)
		{
			// Use is switching sides
			SwitchSides(cbSettingsLeftHanded.Checked);
		}

		private void lbPorts_SelectedIndexChanged(object sender, EventArgs e)
		{
			// set desired com port
			// always remember as new default
			// allow re-connect to new port
			grblPort.comport = cbPorts.SelectedItem;
			// Set as new default
			GrblPanel.My.Settings.Port = cbPorts.SelectedItem;
			btnConnect.Enabled = true;

		}

		private void cbBaud_SelectedIndexChanged(object sender, EventArgs e)
		{
			// set desired baud rate
			grblPort.baudrate = cbBaud.SelectedItem.ToString();
			GrblPanel.My.Settings.Baud = grblPort.baudrate;
			// always remember as new default
			GrblPanel.My.Settings.Save();
			btnConnect.Enabled = true;

		}

		private void btnConnDisconnect_Click(object sender, EventArgs e)
		{
			// Open connection to Grbl
			// This routine is used for both Com and IP connections. Buttons are differentiated by using Tag property.

			Button btn = sender;
			bool connected = false;

			switch (btn.Text) {
				case "Connect":
					switch ((string)btn.Tag) {
						case "COM":
							connected = grblPort.Connect(GrblIF.ConnectionType.Serial);
							if (connected == true) {
								// disable other Connect button to prevent reconnects
								btn.Text = "Disconnect";
								btnIPConnect.Enabled = false;
							} else {
								MessageBox.Show("Please select a Com port" + Constants.vbCr + "or connect the cable", "Connect Error", MessageBoxButtons.OK);
								grblPort.rescan();
								return;
							}
							break;
						case "IP":
							if (tbIPAddress.TextLength <= 0) {
								MessageBox.Show("Please enter an IP Address" + Constants.vbCr + "and a port number in the format" + Constants.vbCr + "\"<ip address>:<port number>\"", "Connect Error", MessageBoxButtons.OK);
								return;
							}

							string[] address = tbIPAddress.Text.Split({ ":" }, StringSplitOptions.RemoveEmptyEntries);
							grblPort.ipaddress = System.Net.IPAddress.Parse(address[0]);
							grblPort.portnum = int.Parse(address[1]);

							if (grblPort.portnum == 0) {
								MessageBox.Show("Please enter an IP Address" + Constants.vbCr + "and a port number in the format" + Constants.vbCr + "\"<ip address>:<port number>\"", "Connect Error", MessageBoxButtons.OK);
								return;
							}
							// finally we try to connect
							connected = grblPort.Connect(GrblIF.ConnectionType.IP);
							if (connected == true) {
								// disable other Connect button to prevent reconnects
								btn.Text = "Disconnect";
								btnConnect.Enabled = false;
							} else {
								MessageBox.Show("Please enter an IP Address" + Constants.vbCr + "and a port number in the format" + Constants.vbCr + "\"<ip address>:<port number>\"", "Connect Error", MessageBoxButtons.OK);
								return;
							}
							break;
					}
					if (connected == true) {
						// Wake up the subsystems
						// TODO Replace these calls with Event Connected handling in each object
						status.enableStatus(true);
						Thread.Sleep(tbSettingsStartupDelay.Text * 1000);
						// Give Grbl time to wake up from Reset

						gcode.enableGCode(true);
						jogging.enableJogging(true);
						position.enablePosition(true);
						offsets.enableOffsets(true);
						state.EnableState(true);
						settings.EnableState(true);

						if (connected != null) {
							connected("Connected");
						}
						// tell everyone of the happy event
						setSubPanels("Idle");
						// Start the status poller
						statusPrompt("Start");
					}
					break;
				case "Disconnect":
					// it must be a disconnect
					grblPort.Disconnect();
					btnConnect.Text = "Connect";
					btnIPConnect.Text = "Connect";
					btnConnect.Enabled = true;
					btnIPConnect.Enabled = true;

					// Stop the status poller
					// TODO Replace these calls with Event Disconnected handling in each object
					statusPrompt("End");
					status.enableStatus(false);
					jogging.enableJogging(false);
					position.enablePosition(false);
					gcode.enableGCode(false);
					offsets.enableOffsets(false);
					state.EnableState(false);
					settings.EnableState(false);

					if (connected != null) {
						connected("Disconnected");
					}

					setSubPanels("Disconnected");
					// block GUI 
					return;
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			// Send a line to Grbl
			gcode.sendGCodeLine(tbSendData.Text);
		}

		private void tbSendData_KeyDown(object sender, KeyEventArgs e)
		{
			// Do same as clicking Send button
			if (e.KeyCode == Keys.Return) {
				// Send a line to Grbl
				gcode.sendGCodeLine(tbSendData.Text);
			}
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			My.MyProject.Forms.AboutBox.ShowDialog();
			My.MyProject.Forms.AboutBox.BringToFront();
		}

		private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TabControl1.SelectedTab = tabPgSettings;
			TabControl1.SelectedTab.Show();

		}


		private void btnFileSend_MouseHover(object sender, EventArgs e)
		{
		}
		private void rescanPorts()
		{
			var _with2 = cbPorts;
			_with2.Items.Clear();
			_with2.Items.AddRange(grblPort.rescan());
		}
		private void btnRescanPorts_Click(object sender, EventArgs e)
		{
			// Refresh the list of ports
			rescanPorts();
		}

		public void enableGrbl(bool action)
		{
			// enable the Grbl connect group
			gbGrbl.Enabled = action;

		}

		public void setSubPanels(string active)
		{
			// enable/disable the various groups/panels on the GUI
			// This prevents user from doing things such as jogging while running a gcode file
			switch (active) {
				case "GCodeStream":
					// We are running a file
					gbJogging.Enabled = false;
					gbPosition.Enabled = false;
					gbMDI.Enabled = false;
					gbGrbl.Enabled = false;
					gbState.Enabled = false;

					gbSettingsJogging.Enabled = false;
					gbSettingsMisc.Enabled = false;
					gbSettingsOffsets.Enabled = false;
					gbSettingsPosition.Enabled = false;
					gbGrblSettings.Enabled = false;

					btnStatusGetParser.Enabled = false;
					break;
				case "Disconnected":
					// We are not connected so not much you can do
					gbJogging.Enabled = false;
					gbPosition.Enabled = false;
					gbMDI.Enabled = false;
					gbGrbl.Enabled = true;
					// Allow only Connect
					gbState.Enabled = false;

					gbSettingsJogging.Enabled = false;
					gbSettingsMisc.Enabled = false;
					gbSettingsOffsets.Enabled = false;
					gbSettingsPosition.Enabled = false;
					gbGrblSettings.Enabled = false;

					btnStatusGetParser.Enabled = false;
					break;
				case "Idle":
					// General use, no gcode streaming
					gbJogging.Enabled = true;
					gbPosition.Enabled = true;
					gbMDI.Enabled = true;
					gbGrbl.Enabled = true;
					gbState.Enabled = true;

					gbSettingsJogging.Enabled = true;
					gbSettingsMisc.Enabled = true;
					gbSettingsOffsets.Enabled = true;
					gbSettingsPosition.Enabled = true;
					gbGrblSettings.Enabled = true;

					btnStatusGetParser.Enabled = true;
					break;
			}
		}

		// Event Handler definitions

		// These are used to tell other objects that something meaningful happened

		// Raised when we succesfully connected to Grbl
		public event ConnectedEventHandler Connected;
		public delegate void ConnectedEventHandler(string msg);


		//Private Sub MacroButtonEditorToolStripMenuItem_Click(sender As Object, e As EventArgs)
		//    GrblMacroButtons.ShowDialog()
		//    EnableMacroButtons()
		//End Sub

		private void EnableMacroButtons()
		{
			Button b = null;
			int iButtonCounter = 0;
			int iButtonMargin = 7;
			int iButtonRowSum = 0;
			int iButtonRowTop = 62;
			Size DefaultDimension = new Size(58, 20);

			string[] macro = null;

			// make sure there are no macro buttons in the group before we add new ones
			for (int iLoopCounter = (gbMDI.Controls.Count - 1); iLoopCounter >= 0; iLoopCounter += -1) {
				Control mButton = gbMDI.Controls[iLoopCounter];

				if (mButton.Name // ERROR: Unknown binary operator Like
) {
					gbMDI.Controls.Remove(mButton);
					mButton.Dispose();
				}
			}


			// now start adding buttons for each macro item in the registry
			//If Not (instance Is Nothing) Then
			foreach (string item in macroNames) {
				macro = Strings.Split(GrblPanel.My.Settings(item), ":");
				if (macro.Count() == 2) {
					b = new Button();
					b.Size = DefaultDimension;
					b.Location = new Point(iButtonRowSum + iButtonMargin, iButtonRowTop);
					b.Name = "btnMacro" + iButtonCounter;
					b.Text = macro[0].ToString();
					b.Tag = macro[1].ToString();

					b.Click += MacroButton_Click;
					gbMDI.Controls.Add(b);
					iButtonRowSum += iButtonMargin + b.Width;
					iButtonCounter += 1;
				}
			}
			//End If
		}


		private void MacroButton_Click(System.Object sender, System.EventArgs e)
		{
			int iCounter = 0;
			string[] aData = null;

			aData = Strings.Split(Strings.Trim(((Button)sender).Tag), Constants.vbCrLf);
			// split the gcode in case the user uses multiple lines 
			for (iCounter = 0; iCounter <= aData.Count() - 1; iCounter++) {
				gcode.sendGCodeLine(aData[iCounter]);
			}
		}
		/// <summary>
		/// Handles the Click event of the btnFeedOverride controls.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>

		private void btnFeedOverride_Click(object sender, EventArgs e)
		{
			Button btn = sender;

			switch ((string)btn.Tag) {
				case "Coarse":
					if (btn.Text == "+") {
						grblPort.sendData(Strings.Chr(94));
					} else {
						grblPort.sendData(Strings.Chr(42));
					}
					break;
				case "Fine":
					if (btn.Text == "+") {
						grblPort.sendData(Strings.Chr(147));
						// 0x93
					} else {
						grblPort.sendData(Strings.Chr(148));
						// 0x94
					}
					break;
			}
		}


		private void Button1_Click(object sender, EventArgs e)
		{
			grblPort.sendData("#");
		}


	}
}
