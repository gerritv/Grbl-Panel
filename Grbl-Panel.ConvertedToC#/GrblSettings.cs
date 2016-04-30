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
using System.Threading.Thread;
namespace GrblPanel
{

	partial class GrblGui
	{
		public class GrblSettings
		{
			// Handle settings related operations


			private GrblGui _gui;
				// to hold the parameters
			private DataTable _paramTable;
				// to track which param line is next
			private int _nextParam;

			#region "Properties"
			public int IsHomingEnabled {
				get {
					DataRow row = null;
					row = _paramTable.Rows.Find("$22");
					if ((row != null)) {
						return row["Value"];
					}
					return 0;
				}
			}
			#endregion

			public GrblSettings(ref GrblGui gui)
			{
				// Get ref to parent object
				_gui = gui;
				// For Connected events
				(_gui.Connected) += GrblConnected;

			}

			public void EnableState(bool yes)
			{
				if (yes) {
					_gui.gbGrblSettings.Enabled = true;
				} else {
					_gui.gbGrblSettings.Enabled = false;
				}
			}

			// Handles GrblGui.Connected Event
			private void GrblConnected(string msg)
			{

				if (msg == "Connected") {
					// We are connected to Grbl so populate the Settings
					_nextParam = 0;
					GrblGui.gcode.sendGCodeLine("$$");
				}
			}

			public void FillSettings(string data)
			{
				// Add a settings line to the display
				//Console.WriteLine("GrblSettings: $ Data is : " + data)
				// Return
				string[] @params = null;
				if (_nextParam == 0) {
					// We are dealing with a fresh
					_paramTable = new DataTable();
					var _with1 = _paramTable;
					_with1.Columns.Add("ID");
					_with1.Columns.Add("Value");
					_with1.Columns.Add("Description");
					_with1.PrimaryKey = new DataColumn[] { _with1.Columns("ID") };
				}
				@params = data.Split({
					'=',
					'(',
					')'
				});
				@params[1] = @params[1].Replace(" ", "");
				// strip trailing blanks
				_paramTable.Rows.Add(@params[0], @params[1], @params[2]);
				_nextParam += 1;

				// We got the last one
				if (@params[0] == _gui.tbSettingsGrblLastParam.Text) {
					_nextParam = 0;
					// in case user does a MDI $$
					var _with2 = _gui.dgGrblSettings;
					_with2.DataSource = _paramTable;
					_with2.Columns("ID").Width = 40;
					_with2.Columns("ID").ReadOnly = true;
					_with2.Columns("ID").DefaultCellStyle.BackColor = SystemColors.Control;
					_with2.Columns("Value").Width = 60;
					_with2.Columns("Description").Width = 200;
					_with2.Columns("Description").ReadOnly = true;
					_with2.Columns("Description").DefaultCellStyle.BackColor = SystemColors.Control;
					_with2.Refresh();
					// Tell everyone we have the params
					if (GrblSettingsRetrieved != null) {
						GrblSettingsRetrieved();
					}
				}

			}

			// Event template for Settings Retrieved indication
			public event GrblSettingsRetrievedEventHandler GrblSettingsRetrieved;
			public delegate void GrblSettingsRetrievedEventHandler();

		}

		// We need a way to propogate changes on the Settings tab, do that here

		private void btnSettingsRefreshMisc_Click(object sender, EventArgs e)
		{
			Button b = sender;
			switch ((string)b.Tag) {
				case "Misc":
					changeStatusRate(GrblPanel.My.Settings.StatusPollInterval);
					prgBarQ.Maximum = GrblPanel.My.Settings.QBuffMaxSize;
					prgbRxBuf.Maximum = GrblPanel.My.Settings.RBuffMaxSize;
					cbStatusPollEnable.Checked = GrblPanel.My.Settings.StatusPollEnabled;
					cbSettingsConnectOnLoad.Checked = GrblPanel.My.Settings.GrblConnectOnLoad;

					break;
				case "Position":
					tbSettingsSpclPosition1.Text = GrblPanel.My.Settings.MachineSpclPosition1;
					tbSettingsSpclPosition2.Text = GrblPanel.My.Settings.MachineSpclPosition2;

					break;

				case "Jogging":
					tbSettingsFIImperial.Text = GrblPanel.My.Settings.JoggingFIImperial;
					tbSettingsFRImperial.Text = GrblPanel.My.Settings.JoggingFRImperial;
					tbSettingsFIMetric.Text = GrblPanel.My.Settings.JoggingFIMEtric;
					tbSettingsFRMetric.Text = GrblPanel.My.Settings.JoggingFRMetric;
					cbSettingsMetric.Checked = GrblPanel.My.Settings.JoggingUnitsMetric;

					setDistanceMetric(cbSettingsMetric.Checked);

					btnXPlus.Interval = 1000 / GrblPanel.My.Settings.JoggingXRepeat;
					btnXMinus.Interval = 1000 / GrblPanel.My.Settings.JoggingXRepeat;
					btnYPlus.Interval = 1000 / GrblPanel.My.Settings.JoggingYRepeat;
					btnYMinus.Interval = 1000 / GrblPanel.My.Settings.JoggingYRepeat;
					btnZPlus.Interval = 1000 / GrblPanel.My.Settings.JoggingZRepeat;
					btnZMinus.Interval = 1000 / GrblPanel.My.Settings.JoggingZRepeat;
					break;
			}
		}


		private void btnSettingsGrbl_Click(object sender, EventArgs e)
		{
			// Retrieve settings from Grbl
			gcode.sendGCodeLine("$$");
		}


		private void dgGrblSettings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			// User wants to edit a Grbl setting
			// We do these one at a time due to EEProm write restrictions
			//Psuedo code:
			// Which row? Get new value, determine $id, send to Grbl, do a refresh ($$)
			if (e.ColumnIndex != 1) {
				// ignore the click, it is not in Value column
				return;
			}
			DataGridView gridView = sender;
			if ((gridView.EditingControl != null)) {
				// we have something to change (aka ignore errant double clicks)
				string param = gridView.Rows[e.RowIndex].Cells[0].Value.ToString() + "=" + gridView.EditingControl.Text;
				gcode.sendGCodeLine(param);
				System.Threading.Thread.Sleep(200);
				// Have to wait for EEProm write
				gcode.sendGCodeLine("$$");
				// Refresh
			}
		}
	}
}
