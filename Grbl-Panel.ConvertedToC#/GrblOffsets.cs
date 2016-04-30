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
using System.Xml;
namespace GrblPanel
{
	partial class GrblGui
	{
		public class GrblOffsets
		{

			private GrblGui _gui;
			private bool _wtgForGrbl = false;
			private bool _collecting = false;

			private List<string> _offsets = new List<string>();
			public GrblOffsets(ref GrblGui gui)
			{
				_gui = gui;

				_gui.Connected += GrblConnected;
			}

			public void enableOffsets(bool action)
			{
				_gui.gbStatus.Enabled = action;
				if (action == true) {
					_gui.grblPort.addRcvDelegate(_gui.showGrblOffsets);
				} else {
					_gui.grblPort.deleteRcvDelegate(_gui.showGrblOffsets);
				}
			}

			public void ClearParams()
			{
				// empty the list of parameters
				_offsets.Clear();
			}

			public void AddOffset(string data)
			{
				// Add a raw parameter line to the list
				_offsets.Add(data);
			}

			public void SaveOffsets()
			{
				// Save the Work and TLO offsets to a file of users' choice
				if (!(_gui.sfdOffsets.ShowDialog() == System.Windows.Forms.DialogResult.OK)) {
					return;
				}

				XmlWriterSettings settings = new System.Xml.XmlWriterSettings();
				settings.Indent = true;
				settings.NewLineOnAttributes = true;


				XmlWriter writer = XmlWriter.Create(_gui.sfdOffsets.FileName, settings);
				Control[] ctls = null;

				writer.WriteStartElement("WorkOffsets");
				foreach (string id in {
					"G54",
					"G55",
					"G56",
					"G57",
					"G58",
					"G59"
				}) {
					writer.WriteStartElement(id);
					foreach (string axis in {
						"X",
						"Y",
						"Z"
					}) {
						ctls = _gui.tpOffsets.Controls.Find("tbOffsets" + id + axis, true);
						writer.WriteAttributeString(axis, ctls[0].Text);
					}
					writer.WriteEndElement();
					// End an offset
				}
				// Do TLO as special

				writer.WriteStartElement("G43");
				ctls = _gui.tpOffsets.Controls.Find("tbOffsetsG43Z", true);
				writer.WriteAttributeString("Z", ctls[0].Text);
				writer.WriteEndElement();

				writer.WriteEndElement();
				// End WorkOffsets
				writer.Close();

			}

			public void LoadOffsets()
			{
				// Load Work and TLO Offsets
				// This lets the user double click on values for which there is a fixture etc. for quick set up
				if (!(_gui.ofdOffsets.ShowDialog() == System.Windows.Forms.DialogResult.OK)) {
					return;
				}

				System.Xml.XmlReader reader = XmlReader.Create(_gui.ofdOffsets.FileName);
				Control[] ctls = null;
				while (reader.Read()) {
					switch (reader.NodeType) {
						case XmlNodeType.Element:
							if (reader.HasAttributes) {
								// This finds only the nodes we need
								string offsetName = reader.Name;
								while (reader.MoveToNextAttribute()) {
									ctls = _gui.tpOffsets.Controls.Find("tbOffsets" + offsetName + reader.Name, true);
									ctls[0].Text = reader.Value;
								}
							}
							break;
					}
				}
			}

			public bool OffsetsWtgForGrbl {
				// Used to enable watch for $ parameters
				get { return _wtgForGrbl; }
				set { _wtgForGrbl = value; }
			}

			public bool CollectingOffsets {
				// True is we are collecting params from response stream
				get { return _collecting; }
				set { _collecting = value; }
			}

			public List<string> Offsets {
				get { return _offsets; }
			}

			// Handles GrblGui.Connected Event
			private void GrblConnected()
			{
				// We are now connected so ask for Offset data
				OffsetsWtgForGrbl = true;
				GrblGui.gcode.sendGCodeLine("$#");
			}
		}



		private void btnOffsetsZero_Click(object sender, EventArgs e)
		{
			Button btn = sender;
			string index = "";
			string tag = (string)btn.Tag;
			tag = tag.Substring(0, 3);
			// Set the Offset to zero
			if (tag.StartsWith("G5")) {
				switch (tag) {
					case "G54":
						index = "P1";
						break;
					case "G55":
						index = "P2";
						break;
					case "G56":
						index = "P3";
						break;
					case "G57":
						index = "P4";
						break;
					case "G58":
						index = "P5";
						break;
					case "G59":
						index = "P6";
						break;
				}
				gcode.sendGCodeLine("G10 L2 " + index + " X0 Y0 Z0");
			} else if (tag.StartsWith("G28") | tag.StartsWith("G30")) {
				// set G28 or G30 to current Machine Position
				gcode.sendGCodeLine(tag.Substring(0, 3) + ".1");
			} else if (tag.StartsWith("G43")) {
				gcode.sendGCodeLine("G43.1 Z0");
			}

			// Get new values
			btnOffsetsRetrieve_Click(null, null);
		}


		private void tbOffsets_DoubleClick(object sender, EventArgs e)
		{
			// Set a specific offset and axis to entered value
			TextBox tb = sender;
			string index = "";
			string tag = (string)tb.Tag;
			string axis = tag[3];
			if (tag.Contains("G5")) {
				switch (tag.Substring(0, 3)) {
					// Get the offset value
					case "G54":
						index = "P1";
						break;
					case "G55":
						index = "P2";
						break;
					case "G56":
						index = "P3";
						break;
					case "G57":
						index = "P4";
						break;
					case "G58":
						index = "P5";
						break;
					case "G59":
						index = "P6";
						break;
				}
				gcode.sendGCodeLine("G10 L2 " + index + " " + axis + tb.Text);
			}

		}
		/// <summary>
		/// Set an offset to current machine coordinates
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnSetOffset_Click(object sender, EventArgs e)
		{
			Button btn = sender;
			string index = "";
			string tag = (string)btn.Tag;
			string XValue = tbOffSetsMachX.Text.ToString();
			string YValue = tbOffSetsMachY.Text.ToString();
			string ZValue = tbOffSetsMachZ.Text.ToString();

			switch (tag.Substring(0, 3)) {
				// Get the offset value
				case "G54":
					index = "P1";
					break;
				case "G55":
					index = "P2";
					break;
				case "G56":
					index = "P3";
					break;
				case "G57":
					index = "P4";
					break;
				case "G58":
					index = "P5";
					break;
				case "G59":
					index = "P6";
					break;
			}
			gcode.sendGCodeLine("G10 L2 " + index + " " + "X" + XValue + "Y" + YValue + "Z" + ZValue);
			// Get new values
			btnOffsetsRetrieve_Click(null, null);

		}

		private void btnOffsetsRetrieve_Click(object sender, EventArgs e)
		{
			// Ask Grbl to send us the present offsets
			offsets.OffsetsWtgForGrbl = true;
			offsets.ClearParams();
			gcode.sendGCodeLine("$#");
		}

		public void showGrblOffsets(string data)
		{
			// We come here from the recv_data thread so have to do this trick to cross threads
			// (http://msdn.microsoft.com/en-ca/library/ms171728(v=vs.85).aspx)
			if (data.Length < 3) {
				return;
			}
			if (this.btnReset.InvokeRequired) {
				// we need to cross thread this callback
				grblDataReceived ncb = new grblDataReceived(this.showGrblOffsets);
				this.BeginInvoke(ncb, new object[] { data });
				return;
			} else {
				// Extract anything with a [<n> into array
				if (offsets.OffsetsWtgForGrbl) {
					if (data[0] == "[" & (data[1] == "G" | data[1] == "T")) {
						offsets.AddOffset(data);
						offsets.CollectingOffsets = true;
					} else if (offsets.CollectingOffsets & data[0] != "[") {
						// we are done collecting parameters, time to display them
						offsets.OffsetsWtgForGrbl = false;
						offsets.CollectingOffsets = false;
						ShowOffsets();
					}
				}
			}
		}

		public void ShowOffsets()
		{
			// TODO move into offsets class, needs ref to grblgui object
			// Populate the Offsets display
			string label = null;
			string[] axes = null;
			Control[] tb = null;
			foreach (string line_loopVariable in offsets.Offsets) {
				line = line_loopVariable;
				line = line.Remove(0, 1);
				// remove the leading [
				line = line.Remove(line.Length - 3, 3);
				// remove the trailing "] <vbLf>"
				label = line.Substring(0, 3);
				line = line.Remove(0, 4);
				// finally remove the label:
				axes = line.Split(",");
				switch (label) {
					case "G28":
					case "G30":
						int i = 0;
						foreach (string axi_loopVariable in {
							"X",
							"Y",
							"Z"
						}) {
							axi = axi_loopVariable;
							tb = tabPgSettings.Controls.Find("tbOffsets" + label + axi, true);
							tb[0].Text = axes[i];
							i += 1;
						}

						break;
					case "G54":
					case "G55":
					case "G56":
					case "G57":
					case "G58":
					case "G59":
						int i = 0;
						foreach (string axi_loopVariable in {
							"X",
							"Y",
							"Z"
						}) {
							axi = axi_loopVariable;
							tb = tpOffsets.Controls.Find("tbOffsets" + label + axi, true);
							tb[0].Text = axes[i];
							i += 1;
						}

						break;
					case "TLO":
						tb = tpOffsets.Controls.Find("tbOffsets" + "G43" + "Z", true);
						tb[0].Text = axes[0];
						break;
				}
			}
		}

		private void btnOffsetsSave_Click(object sender, EventArgs e)
		{
			// Save Work and TLO offsets
			offsets.SaveOffsets();
		}

		private void btnOffsetsLoad_Click(object sender, EventArgs e)
		{
			// Load offsets from user specified file
			offsets.LoadOffsets();
		}
	}
}
