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
namespace GrblPanel
{
	partial class GrblGui
	{
		public class GrblState
		{

			// A class to track and display Gcode state
			// e.g. to show active G90/91 or Work/Fixture offset

			// Gets fed each line of Gcode before it is sent to 
			// Gets fed the response to $G (Parser state)

			private GrblGui _gui;
			public GrblState(ref GrblGui gui)
			{
				// Get ref to parent object
				_gui = gui;
				// For Connected events
				(My.MyProject.Forms.GrblGui.Connected) += GrblConnected;

			}

			public void EnableState(bool yes)
			{
				if (yes) {
					_gui.gbState.Enabled = true;
				} else {
					_gui.gbStatus.Enabled = false;
				}
			}

			// Handles GrblGui.Connected Event
			private void GrblConnected(string msg)
			{

				if (msg == "Connected") {
					// We are connected to Grbl so populate the State
					GrblGui.gcode.sendGCodeLine("$G");
				}
			}

			public void ProcessGCode(string line)
			{
				// parse the line for codes we are interested in
				// We get our data from:
				// - Outbound Gcode
				// - Response from Grbl to $G

				char[] ignore = {
					"$",
					"!",
					"~",
					"?",
					"("
				};
				char[] codes = {
					"M",
					"T",
					"S",
					"G",
					"F"
				};
				char[] allcodes = {
					"M",
					"T",
					"F",
					"G",
					"P",
					"S",
					"X",
					"Y",
					"Z",
					"I",
					"J",
					"K",
					" ",
					"[",
					"]",
					Constants.vbLf
				};
				char[] spclcodes = {
					"T",
					"S",
					"F"
				};
				bool collect = false;
				// collect code characters
				string[] gcodes = {
					
				};
				// the gcodes found
				int gcodeIndex = 0;
				// current entry being processed

				bool comment = false;
				// Deal with blank lines
				if (line.Length == 0) {
					return;
				}
				if (ignore.Contains(line[0]) | (!allcodes.Contains(line[0]))) {
					return;
					// ignore lines with no gcode
				}
				foreach (char c in line) {
					if (c == "(") {
						break; // TODO: might not be correct. Was : Exit For
						// we are done parsing this line
					}
					// did we find a gcode block?
					if (allcodes.Contains(c)) {
						collect = false;
						// we reached end of what we were collecting
						// is it one we care about?
						if (codes.Contains(c)) {
							collect = true;
							Array.Resize(ref gcodes, gcodeIndex + 2);
							gcodes[gcodeIndex] = c;
							gcodeIndex += 1;
						}
					} else {
						// are we in a gcode block?
						if (collect) {
							gcodes[gcodeIndex - 1] += c;
						}
					}
				}
				// parsing done, lets see what we 
				//(settings are explicit to avoid showing an assumed value. If we don't know, then box is empty)
				// TODO Remove leading 0's from numbers
				foreach (string code_loopVariable in gcodes) {
					code = code_loopVariable;
					if ((code == null)) {
						break; // TODO: might not be correct. Was : Exit For
					}
					if (spclcodes.Contains(code[0])) {
						// Handle F, S and T
						switch (code[0]) {
							case "T":
								_gui.tbStateTool.Text = code.Remove(0, 1);
								break;
							case "S":
								_gui.tbStateSpindleRPM.Text = code.Remove(0, 1);
								break;
							case "F":
								_gui.tbStateFeedRate.Text = code.Remove(0, 1);
								break;
						}
					} else {
						switch (code) {
							case "G20":
							case "G21":
								_gui.cbxStateUnits.SelectedItem = find(_gui.cbxStateUnits, code);
								break;
							case "G54":
							case "G55":
							case "G56":
							case "G57":
							case "G58":
							case "G59":
								_gui.cbxStateOffset.SelectedItem = find(_gui.cbxStateOffset, code);
								_gui.lblPositionCurrentOffset.Text = find(_gui.cbxStateOffset, code);
								break;
							case "G90":
							case "G91":
								_gui.cbxStateDistance.SelectedItem = find(_gui.cbxStateDistance, code);
								break;
							case "G93":
							case "G94":
								_gui.cbxStateFeedMode.SelectedItem = find(_gui.cbxStateFeedMode, code);
								break;
							case "G17":
							case "G18":
							case "G19":
								// Plane           
								_gui.cbxStatePlane.SelectedItem = find(_gui.cbxStatePlane, code);
								break;
							case "M3":
							case "M4":
							case "M5":
								// Motor control
								_gui.cbxStateSpindle.SelectedItem = find(_gui.cbxStateSpindle, code);
								break;
							case "M8":
							case "M9":
								_gui.cbxStateCoolant.SelectedItem = find(_gui.cbxStateCoolant, code);
								break;
						}
					}
					var x = 1;
				}

			}

			private object find(ComboBox bx, string code)
			{
				// I should overload ComboBox FindString but then we get a custom control :-(
				// so we do this instead
				foreach (object i in bx.Items) {
					if (i.ToString().Contains(code)) {
						return i;
					}
				}
				return null;
			}
		}

		private void cbxState_SelectionChangeCommittted(object sender, EventArgs e)
		{
			// Send new setting to Grbl
			ComboBox cbx = sender;
			string code = cbx.SelectedItem;
			if (!string.IsNullOrEmpty(code)) {
				code = code.Substring(code.Length - 3, 3);
				gcode.sendGCodeLine(code);
			}
		}
	}
}
