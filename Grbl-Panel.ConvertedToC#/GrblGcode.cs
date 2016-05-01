using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
namespace GrblPanel
{

    partial class GrblGui
	{


		public class GrblGcode
		{
			// A Class to handle reading, parsing, removing white space
			//   - Handles the sending to Grbl using either the simple or advanced protocols
			//   - Handles introducing canned cycles (M06, G81/2/3)
			// While we are sending the file, lock out manual functions
			private GrblGui _gui;
				//
			private bool _wtgForAck = false;
				//
			private bool _runMode = true;
				//
			private bool _sendAnotherLine = false;
				// No of lines left to send
			private int _lineCount = 0;
			private int _linesDone = 0;
				// M30 detected in gcode stream
			private bool _m30Flag = false;

			// Handle file read (Gcode in) and Write (Gcode save)
			private StreamReader _inputfh;

			private int _inputcount;
			// For timings

			Stopwatch _stopwatch = new Stopwatch();

			public GrblGcode(ref GrblGui gui)
			{
				_gui = gui;
			}

			public void enableGCode(bool action)
			{
				// Can't use new if we need to reference _gui as it causes Form creation errors
				_gui.gbGcode.Enabled = action;
				if (action == true) {
					// Enable looking at responses now, for use by manual commands
					_gui.grblPort.addRcvDelegate(_gui.processLineEvent);
					_gui.btnFileSelect.Enabled = true;
				} else {
					_gui.grblPort.deleteRcvDelegate(_gui.processLineEvent);
				}
			}

			public bool loadGCodeFile(string file)
			{
				string data = null;
				// Start from clean slate
				resetGcode(true);
				// Load the file, count lines
				_inputfh = GrblPanel.My.MyProject.Computer.FileSystem.OpenTextFileReader(file);
				// count the lines while loading up
				_inputcount = 0;

				while (!_inputfh.EndOfStream) {
					data = _inputfh.ReadLine();
					// Issue #20, ignore '%'
					if (data != "%") {
						GrblGui.gcodeview.Insert(data, "File", (_inputcount + 1).ToString());
						// Plan B
						_inputcount += 1;
					}
				}
				lineCount = _inputcount;

				GrblGui.gcodeview.RefreshView(lineCount);
				// refresh data to the DataGridView

				if ((_inputfh != null)) {
					_inputfh.Close();
				}
				// Issue #19

				return true;

			}
			public void closeGCodeFile()
			{
				if ((_inputfh != null)) {
					_inputfh.Close();
				}
				_gui.tbGcodeFile.Text = "";
				_inputcount = 0;

			}

			public void sendGcodeFile()
			{
				_stopwatch.Reset();
				_stopwatch.Start();
				// Workflow:
				// Disable other panels to prevent operator error
				_gui.setSubPanels("GCodeStream");
				// set sendAnotherLine
				// raise processLineEvent
				lineCount = _inputcount;
				linesDone = 0;
				wtgForAck = false;
				runMode = true;
				sendAnotherLine = true;
				gcodeview.fileMode = true;
				_gui.processLineEvent("");
				// Prime the pump
			}

			public void sendGCodeLine(string data)
			{
				// Send a line immediately
				// This can only happen when not sending a file, buttons are interlocked
				_runMode = false;
				gcodeview.fileMode = false;

				if (!(data.StartsWith("$") | data.StartsWith("?"))) {
					var _with1 = gcodeview;
					// add to display
					// _gui.gcodeview.Insert(data, 0)
					_with1.Insert(data, "MDI", 0.ToString());
					gcode.lineCount += 1;
					// we are always be the last item in manual mode
					_with1.UpdateGcodeSent(-1);
					// Expect a response from Grbl
					wtgForAck = true;
				}
				_gui.state.ProcessGCode(data);
				// Keep Gcode State object in the loop
				_gui.grblPort.sendData(data);

			}

			public void sendGCodeFilePause()
			{
				// Pause the file send
				_sendAnotherLine = false;
				_runMode = false;
			}

			public void sendGCodeFileResume()
			{
				// Resume sending of file
				_sendAnotherLine = true;
				_runMode = true;
				GrblGui.gcodeview.fileMode = true;
				_gui.processLineEvent("");
				// Prime the pump again

			}

			public void sendGCodeFileStop()
			{
				// reset state variables
				if (runMode) {
					wtgForAck = false;
					runMode = false;
					sendAnotherLine = false;
					GrblGui.gcodeview.fileMode = false;
					// allow manual mode gcode send

					// Make the fileStop button go click, to stop the file send
					// and set the buttons
					_gui.btnFileGroup_Click(_gui.btnFileStop, null);
				}

			}
			public void sendGCodeFileRewind()
			{
				_stopwatch.Stop();
				_gui.tbGCodeMessage.Text = "Elapsed: " + _stopwatch.Elapsed.ToString();

				// reset state variables
				if (runMode) {
					wtgForAck = false;
					runMode = false;
					sendAnotherLine = false;
					GrblGui.gcodeview.fileMode = false;
					// allow manual mode gcode send

					GrblGui.gcode.sendGCodeFilePause();
					//gcode.closeGCodeFile()
					var _with2 = _gui;
					// Re-enable manual control
					_with2.setSubPanels("Idle");
					_with2.btnFileSelect.Enabled = true;
					_with2.btnFileSend.Tag = "Send";
					_with2.btnFileSend.Enabled = true;
					_with2.btnFilePause.Enabled = false;
					_with2.btnFileStop.Enabled = false;
					_with2.btnFileReload.Enabled = true;
				}
				GrblGui.gcodeview.Rewind();
			}

			public void shutdown()
			{
				// Close up shop
				resetGcode(true);
			}

			private void resetGcode(bool fullstop)
			{
				// Clear out all variables etc to initial state
				lineCount = 0;
				linesDone = 0;
				_gui.lblTotalLines.Text = "";
				_gui.tbGCodeMessage.Text = "";
				// reset state variables
				wtgForAck = false;
				runMode = false;
				sendAnotherLine = false;

				if (fullstop) {
					// clear out the file name etc
					closeGCodeFile();
					// Clear the list of gcode block sent
					GrblGui.gcodeview.Clear();
				}
			}

			#region "Properties"

			public bool runMode {
				get { return _runMode; }
				set { _runMode = value; }
			}
			public bool wtgForAck {
				get { return _wtgForAck; }
				set { _wtgForAck = value; }
			}
			public bool sendAnotherLine {
				get { return _sendAnotherLine; }
				set { _sendAnotherLine = value; }
			}

			public int linesDone {
				get { return _linesDone; }
				set { _linesDone = value; }
			}

			public int lineCount {
				get { return _lineCount; }
				set { _lineCount = value; }
			}
			public bool m30Flag {
				get { return _m30Flag; }
				set { _m30Flag = value; }
			}

			#endregion

		}


		public void processLineEvent(string data)
		{
			// This event handles processing and sending GCode lines from the file as well as ok/error responses from Grbl
			// Implements simple protocol (send block, wait for ok/error loop)
			// It runs on the UI thread, and is raised for each line received from Grbl
			// even when there is no file to send, e.g. due to status poll response

			// we need this to run in the UI thread so:
			//Console.WriteLine("processLineEvent: " + data)
			if (this.dgvGcode.InvokeRequired) {
				// we need to cross thread this callback
				grblDataReceived ncb = new grblDataReceived(this.processLineEvent);
				this.BeginInvoke(ncb, new object[] { data });
			} else {
				// are we waiting for Ack?
				if (gcode.wtgForAck) {
					// is recvData ok or error?

					if (data.StartsWith("ok") | data.StartsWith("error")) {
						// Mark gcode item as ok/error
						gcodeview.UpdateGCodeStatus(data, gcode.linesDone - 1);
						// No longer waiting for Ack
						gcode.wtgForAck = false;
						// Handle rewind of gcode if this ack/ok was for an M30
						if (gcode.m30Flag == true) {
							gcode.m30Flag = false;
							gcode.sendGCodeFileRewind();
							// reset to beginning
						}
						// if not paused or stopped
						if (gcode.runMode) {
							// Mark sendAnotherLine
							gcode.sendAnotherLine = true;
						}
					}
				}
				// Do we have another line to send?
				// if not paused or stopped
				if (gcode.runMode == true) {
					if (gcode.sendAnotherLine) {
						gcode.sendAnotherLine = false;
						// if count > 0
						if (gcode.lineCount > 0) {
							string line = null;
							// Read another line
							line = gcodeview.readGcode(gcode.lineCount, gcode.linesDone);
							// We never hit this but is here just in case the file gets truncated
							if (!line.StartsWith("EOF")) {
								// count - 1
								gcode.lineCount -= 1;
								// show as sent
								gcodeview.UpdateGcodeSent(gcode.linesDone);
								// Mark line as sent
								gcode.linesDone += 1;
								state.ProcessGCode(line);
								// Set Message if it starts with (
								if (line.StartsWith("(")) {
									string templine = line;
									templine = templine.Remove(0, 1);
									templine = templine.Remove(templine.Length - 1, 1);
									tbGCodeMessage.Text = templine;
								}
								if (line.StartsWith("m30") | line.StartsWith("M30")) {
									// Set M30 flag to rewind on 'ok'
									gcode.m30Flag = true;
								}
								// Remove all whitespace
								line = line.Replace(" ", "");
								// set wtg for Ack
								gcode.wtgForAck = true;
								// Ship it Dano!
								grblPort.sendData(line);
							}
						} else {
							// We reached the EOF aka linecount=0, yippee
							gcode.sendGCodeFileStop();
						}
					}
				}
				// Check for status responses that we need to handle here
				// Extract status
				var status = Strings.Split(data, ",");
				if (status[0] == "<Alarm" | status[0].StartsWith("ALARM")) {
					// Major problem so cancel the file
					// GrblStatus has set the Alarm indicator etc
					gcode.sendGCodeFileStop();
				}
				if (status[0].StartsWith("error")) {
					// We pause file send to allow operator to determine proceed or not
					if (cbSettingsPauseOnError.Checked) {
						btnFilePause.PerformClick();
					}
				}
			}
		}

		private void btnCheckMode_Click(object sender, EventArgs e)
		{
			// Enable/disable Check mode in Grbl
			// Just send a $C, this toggles Check state in Grbl
			grblPort.sendData("$C");
		}

		private void btnFileGroup_Click(object sender, EventArgs e)
		{
			// This event handler deals with the gcode file related buttons
			// Implements a simple state machine to keep user from clicking the wrong buttons
			// Uses button.tag instead of .text so the text doesn't mess up the images on the buttons
			Button args = (Button)sender;
			switch ((string)args.Tag) {
				case "File":
					string str = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
					ofdGcodeFile.InitialDirectory = Path.Combine(Path.GetFullPath(str), "*");
					if (!string.IsNullOrEmpty(tbSettingsDefaultExt.Text)) {
						ofdGcodeFile.Filter = string.Format("Gcode |*.{0}|All Files |*.*", tbSettingsDefaultExt.Text);
						ofdGcodeFile.DefaultExt = string.Format(".{0}", tbSettingsDefaultExt.Text);
					}
					ofdGcodeFile.FileName = "File";

					if (ofdGcodeFile.ShowDialog() == DialogResult.OK) {
						//gcode.openGCodeFile(ofdGcodeFile.FileName)
						gcode.loadGCodeFile(ofdGcodeFile.FileName);
						tbGcodeFile.Text = ofdGcodeFile.FileName;
						lblTotalLines.Text = gcode.lineCount.ToString();

						btnFileSelect.Enabled = true;
						// Allow changing your mind about the file
						btnFileSend.Enabled = true;
						btnFilePause.Enabled = false;
						btnFileStop.Enabled = false;
						btnFileReload.Enabled = false;
						// reset filter in case user changes ext on Settings tab
						ofdGcodeFile.Filter = "";
						ofdGcodeFile.DefaultExt = "";
					}
					break;
				case "Send":
					// Send a gcode file to Grbl
					gcode.sendGcodeFile();

					btnFileSelect.Enabled = false;
					btnFileSend.Enabled = false;
					btnFilePause.Enabled = true;
					btnFileStop.Enabled = true;
					btnFileReload.Enabled = false;

					break;
				case "Pause":
					gcode.sendGCodeFilePause();

					btnFileSelect.Enabled = false;
					btnFileSend.Tag = "Resume";
					btnFileSend.Enabled = true;
					btnFilePause.Enabled = false;
					btnFileStop.Enabled = true;
					btnFileReload.Enabled = false;

					break;
				case "Stop":
					gcode.sendGCodeFilePause();
					gcode.closeGCodeFile();
					// Re-enable manual control
					setSubPanels("Idle");

					btnFileSelect.Enabled = true;
					btnFileSend.Tag = "Send";
					btnFileSend.Enabled = false;
					btnFilePause.Enabled = false;
					btnFileStop.Enabled = false;
					btnFileReload.Enabled = true;

					break;
				case "Resume":
					gcode.sendGCodeFileResume();

					btnFileSelect.Enabled = false;
					btnFileSend.Tag = "Send";
					btnFileSend.Enabled = false;
					btnFilePause.Enabled = true;
					btnFileStop.Enabled = true;
					btnFileReload.Enabled = false;

					break;
				case "Reload":
					// Reload the same file 
					gcode.loadGCodeFile(ofdGcodeFile.FileName);
					tbGcodeFile.Text = ofdGcodeFile.FileName;
					lblTotalLines.Text = gcode.lineCount.ToString();

					btnFileSelect.Enabled = true;
					// Allow changing your mind about the file
					btnFileSend.Enabled = true;
					btnFilePause.Enabled = false;
					btnFileStop.Enabled = false;
					btnFileReload.Enabled = false;
					// ensure display is at top of gcode
					gcodeview.DisplayTop();

					break;
			}
		}
		public GrblGui()
		{
			FormClosing += grblgui_unload;
			Load += grblgui_Load;
			Load += GrblMacroButtons_Load;
			FormClosing += GrblMacroButtons_FormClosing;
			InitializeComponent();
		}

	}
}
