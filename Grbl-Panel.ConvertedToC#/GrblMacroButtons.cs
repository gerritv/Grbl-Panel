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
		private bool bDataChanged = false;
		/// <summary>
		/// The fixed names of Macros in Settings
		/// </summary>
		private string[] _macroNames = {
			"Macro1",
			"Macro2",
			"Macro3",
			"Macro4",
			"Macro5"

		};
		private void GrblMacroButtons_FormClosing(object sender, FormClosingEventArgs e)
		{
			int retval = 0;
			if (bDataChanged) {
				retval = Interaction.MsgBox("Are you sure you want to exit without saving your Macro changes?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirm exit without saving.");
				if (retval == Constants.vbYes) {
					e.Cancel = false;
				} else {
					e.Cancel = true;
				}
			}
		}

		private void GrblMacroButtons_Load(object sender, EventArgs e)
		{
			FillListFromSettings();
			var _with1 = dgMacros;
			_with1.Columns(0).Width = _with1.Width;
			// resize the first column to the width of the entire grid, this hides the Gcode column
			//If .RowCount = 0 Then              ' if there are no macros add a default one to the list as an example
			//    .Rows.Add("Probe", "G38.2 Z-30 F10")
			//    bDataChanged = True
			//End If
			btnAdd.Text = "Add";
			tbName.Text = "";
			tbGCode.Text = "";
		}

		private void FillListFromSettings()
		{
			string[] sTemp = null;

			var _with2 = dgMacros;
			_with2.RowCount = 0;
			// make sure the grid is empty
			// add records to the grid 
			foreach (string KeyName in _macroNames) {
				sTemp = Strings.Split(GrblPanel.My.Settings(KeyName), ":");
				if (sTemp.Count() == 2) {
					_with2.Rows.Add(sTemp[0], sTemp[1]);
				}
			}
			bDataChanged = false;
			// reset our changed data flag

		}

		private void btnOK_Click(System.Object sender, System.EventArgs e)
		{
			SaveMacros();
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}


		private void SaveMacros()
		{
			int index = 0;

			foreach (string macro_loopVariable in _macroNames) {
				macro = macro_loopVariable;
				GrblPanel.My.Settings(macro) = "";
			}

			foreach (DataGridViewRow row in dgMacros.Rows) {
				GrblPanel.My.Settings(_macroNames[index]) = row.Cells[0].Value.ToString() + ":" + row.Cells[1].Value.ToString();
				index += 1;
			}
			GrblPanel.My.Settings.Save();
			bDataChanged = false;

			// reload onto MDI display
			EnableMacroButtons();
		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		private void dgMacros_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			bDataChanged = true;
		}

		private void dgMacros_DoubleClick(object sender, EventArgs e)
		{
			var _with3 = dgMacros;
			if (_with3.CurrentRow.Index >= 0) {
				tbName.Text = _with3.Item(0, _with3.CurrentRow.Index).Value;
				tbGCode.Text = _with3.Item(1, _with3.CurrentRow.Index).Value;
				btnAdd.Text = "Update";
			}
		}

		private void btnDeleteMacro_Click(object sender, EventArgs e)
		{
			int retval = 0;
			string sMsg = null;

			var _with4 = dgMacros;
			if (_with4.CurrentRow.Index >= 0) {
				sMsg = "Are you sure you want to delete the " + _with4.Item(0, _with4.CurrentRow.Index).Value.ToString + " macro?";
				retval = Interaction.MsgBox(sMsg, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirm Delete");
				if (retval == Constants.vbYes) {
					_with4.Rows.Remove(_with4.CurrentRow);
					bDataChanged = true;
				}
			}

		}


		private void UpdateToolTip(object sender, EventArgs e)
		{
			string sTemp = null;

			if (object.ReferenceEquals(sender, tbName)) {
				sTemp = "Name appears on the button, so keep it small";
			} else if (object.ReferenceEquals(sender, btnDeleteMacro)) {
				sTemp = "Delete the selected macro";
			} else if (object.ReferenceEquals(sender, dgMacros)) {
				sTemp = "DblClick name to edit macro";
			} else if (object.ReferenceEquals(sender, btnCancel)) {
				sTemp = "Get me outta here, cancel all changes";
			} else if (object.ReferenceEquals(sender, tbGCode)) {
				sTemp = "G-Code to send when the button is clicked.";
			} else if (object.ReferenceEquals(sender, btnOK)) {
				sTemp = "Commit all changes to Settings and close";
			} else {
				sTemp = "Limit is 5 macros";
			}

			lblStatusLabel.Text = sTemp;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bool bMatchFound = false;

			if (!string.IsNullOrEmpty(tbName.Text)) {
				if (!string.IsNullOrEmpty(tbGCode.Text)) {
					if (btnAdd.Text == "Update") {
						foreach (DataGridViewRow row in dgMacros.Rows) {
							if (row.Cells[0].Value.ToString() == tbName.Text) {
								row.Cells[1].Value = tbGCode.Text;
								bMatchFound = true;
								break; // TODO: might not be correct. Was : Exit For
							}
						}
						// if the user changed the name we cannot update so we need to add
						if (!bMatchFound) {
							dgMacros.Rows.Add(tbName.Text, tbGCode.Text);
						}
					} else {
						dgMacros.Rows.Add(tbName.Text, tbGCode.Text);
					}
					bDataChanged = true;
					btnAdd.Text = "Add";
					tbGCode.Text = "";
					tbName.Text = "";
				} else {
					Interaction.MsgBox("You need to add some G-code to save a macro", MsgBoxStyle.Information, "Data Validation Error");
				}
			} else {
				Interaction.MsgBox("You cannot create a macro without a name.", MsgBoxStyle.Information, "Data Validation Error");
			}
		}

		public string[] macroNames {
			get { return _macroNames; }
		}
	}
}
