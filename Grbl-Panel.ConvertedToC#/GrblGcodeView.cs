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
using System.Reflection;
namespace GrblPanel
{

	partial class GrblGui
	{
		public class GrblGcodeView
		{
			// A class to manage the Gcode list view
			// This contains the GCode queue going to Grbl
			// GrblGui owns the dgvGcode control but this class manages its content

			private DataGridView _dgview;
			private List<gcodeItem> _gcodeTable;
				// True if in File Send mode
			private bool _filemode = false;

			private BindingSource _source = new BindingSource();
			public class gcodeItem
			{
				//(Type)
				private string _gcode;
				// Information about the gcode line
					// Is line from file or MDI?
				private bool _file = false;
				private int _lineNum;
				private string _status;
					// Was the line sent?
				private bool _sent = false;
					// Was the line Ack'd?
				private bool _acked = false;
					// Does this line contain M0 Pause?
				private bool _M0 = false;
					// Does this line contain M06 Tool Change?
				private bool _M6 = false;
				#region "gcodeItem Properties"
				public string status {
					get { return _status; }
					set { _status = value; }
				}
				public int lineNum {
					get { return _lineNum; }
					set { _lineNum = value; }
				}
				public string gcode {
					get { return _gcode; }
					set { _gcode = value; }
				}
				public bool file {
					get { return _file; }
					set { _file = value; }
				}
				public bool sent {
					get { return _sent; }
					set { _sent = value; }
				}
				public bool acked {
					get { return _acked; }
					set { _acked = value; }
				}
				#endregion
			}


			public GrblGcodeView(ref DataGridView view)
			{
				_gcodeTable = new List<GrblGcodeView.gcodeItem>();
				//_source.DataSource = _gcodeTable
				//_dgview.DataSource = _source
				_dgview = view;

				var _with1 = _dgview;
				// http://stackoverflow.com/questions/4255148/how-to-improve-painting-performance-of-datagridview
				DoubleBuffered(ref _dgview, true);
				// Improve performance of refresh!
				_with1.DefaultCellStyle.Font = new Font("microsoft san serif", 10);
				_with1.RowTemplate.Height = 17;
				_with1.RowCount = 17;
				// For Virtual mode
				//.Columns("file").Visible = False
				_with1.Columns("stat").Width = 46;
				_with1.Columns("stat").HeaderText = "Sts";
				_with1.Columns("lineNum").Width = 46;
				_with1.Columns("lineNum").HeaderText = "Line";
				_with1.Columns("data").Width = 459;
				_with1.Columns("data").HeaderText = "Gcode";
				//.Columns("sent").Visible = False
				//.Columns("acked").Visible = False
			}
			/// <summary>
			/// Set DataGridView to double buffered. Noticeably implroves refresh performance
			/// </summary>
			/// <param name="dgv">The DataGridView.</param>
			/// <param name="setting">if set to <c>true</c> [setting].</param>
			private void DoubleBuffered(ref DataGridView dgv, bool setting)
			{
				Type dgvtype = dgv.GetType();
				PropertyInfo pi = dgvtype.GetProperty("DoubleBuffered", BindingFlags.Instance + BindingFlags.NonPublic);
				pi.SetValue(dgv, setting);
			}

			/// <summary>
			/// Clears the gcode list/queue.
			/// </summary>
			public void Clear()
			{
				_gcodeTable.Clear();
				_filemode = false;
				// need to move this to Gcode obj
				_dgview.RowCount = 0;
				_dgview.Refresh();
			}
			/// <summary>
			/// Inserts a gcode line into the list/queuea.
			/// </summary>
			/// <param name="data">The data.</param>
			/// <param name="source">The source. "File" or "MDI"</param>
			/// <param name="lineNumber">The line number. Line in file or 0 for MDI</param>
			public void Insert(string data, string source, string lineNumber)
			{
				// Inserts gcode line into the dt
				// Scans for interesting blocks such as M0, M6
				//Dim gcodes() As String
				gcodeItem newGcode = new gcodeItem();
				newGcode.gcode = data;
				newGcode.lineNum = lineNumber;
				switch (source) {
					case "File":
						newGcode.file = true;
						_gcodeTable.Add(newGcode);
						break;
					// The loader is responsible for calling RefreshView at end of load
					case "MDI":
						newGcode.file = false;
						_gcodeTable.Add(newGcode);
						RefreshView(_gcodeTable.Count);
						// keep the view updated
						break;
				}
				// TODO Add special cases
				//gcodes = ParseGcode(data)
				//If gcodes.Contains("M0") Then
				//    info.M0 = True
				//End If
				//If gcodes.Contains("M6") Then
				//    info.M6 = True
				//End If
				//_gcodeTable.Rows.InsertAt(newR, InsertPtr)       ' This is what we need for editing
			}
			/// <summary>
			/// Gets a gcode line.
			/// </summary>
			/// <param name="lineCount">The line count.</param>
			/// <param name="linesDone">The lines done.</param>
			/// <returns></returns>
			public string readGcode(int lineCount, int linesDone)
			{
				// Read a line, if EOF then return EOF
				if (lineCount > 0) {
					//Return _dgview.Rows(linesDone).Cells(2).Value
					return _gcodeTable[linesDone].gcode;
				} else {
					return "EOF";
				}
			}

			/// <summary>
			/// Gets a gcode item.
			/// </summary>
			/// <param name="index">The index.</param>
			/// <returns></returns>
			public gcodeItem GetGcodeItem(int index)
			{
				if (_gcodeTable.Count > 0) {
					return _gcodeTable[index];
				} else {
					return null;
				}
			}

			/// <summary>
			/// Peek at line previously sent
			/// </summary>
			/// <returns>Previous Gcode line</returns>
			public string readGcodePrevious(int lineCount, int linesDone)
			{
				// Read a line, if EOF then return EOF
				if (lineCount >= 0) {
					return _gcodeTable[linesDone - 1].gcode;
				} else {
					return "EOF";
				}
			}
			/// <summary>
			/// Updates the gcode line display status.
			/// </summary>
			/// <param name="stat">The status, e.g. "ok", "error", "sent".</param>
			/// <param name="index">The index.</param>
			public void UpdateGCodeStatus(string stat, int index)
			{
				// Set the Status column of the line item
				// Keep current active line visible in the view

				// locals to boost performance, these methods have an apparent performance impact
				int firstDisplayed = _dgview.FirstDisplayedScrollingRowIndex;
				int displayCount = _dgview.DisplayedRowCount(false);

				if (_filemode) {
					_gcodeTable[index].status = stat;
					//_dgview.Rows(index).Cells(0).Value = stat
					if (index < firstDisplayed) {
						// Make top of queue visible again
						_dgview.FirstDisplayedScrollingRowIndex = 0;
					} else {
						if ((firstDisplayed + displayCount <= index)) {
							_dgview.FirstDisplayedScrollingRowIndex = index - displayCount;
							// + 5
						}
					}
				// MDI mode: we always pick the last entry
				} else {
					_gcodeTable[_gcodeTable.Count - 1].status = stat;
					//_dgview.Rows(_gcodeTable.Count - 1).Cells(0).Value = stat
					// we are in MDI mode so use bottom
					index = _dgview.RowCount - 1;
					if (index < firstDisplayed) {
						// Make top of queue visible again
						_dgview.FirstDisplayedScrollingRowIndex = 0;
					} else {
						if ((firstDisplayed + displayCount <= index) & index != 0) {
							_dgview.FirstDisplayedScrollingRowIndex = index - displayCount + 2;
						}
					}
				}

				// make display look responsive when doing first 16 lines
				if (firstDisplayed <= displayCount) {
					//Console.WriteLine("UpdateGCodeStatus: FirstIndex, DisplayRowCount, index {0} {1} {2}", firstDisplayed, displayCount, index)
					_dgview.Refresh();
				}

			}

			/// <summary>
			/// Mark gcode line as sent.
			/// </summary>
			/// <param name="index">The index.</param>
			public void UpdateGcodeSent(int index)
			{
				//  Set background to indicate the gcode line was sent
				// Are we running a file
				if (_filemode) {
					//_dgview.Rows(index).DefaultCellStyle.BackColor = Color.LightBlue ' gives a noticeable performance hit
					_gcodeTable[index].status = "Sent";
				} else {
					//If _gcodeTable.Count = 1 Then
					//    index = -1
					//End If
					_gcodeTable[_gcodeTable.Count + index].status = "Sent";
					_dgview.Refresh();
					//_dgview.Rows(_gcodeTable.Count + index).DefaultCellStyle.BackColor = Color.LightBlue
				}

			}
			/// <summary>
			/// Refreshes the view. Use after adding or clearing datasource, e.g. file read or MDI input
			/// </summary>
			public void RefreshView(int lineCount)
			{
				_dgview.RowCount = lineCount;
				_dgview.Refresh();

			}
			/// <summary>
			/// Rewind the Gcode view (for M30)
			/// </summary>
			public void Rewind()
			{
				// clear status, leave commands
				foreach (gcodeItem item in _gcodeTable) {
					item.status = null;
				}
				_dgview.FirstDisplayedScrollingRowIndex = 0;
				// show top of file for user to verify etc
				_dgview.Refresh();
			}

			/// <summary>
			/// Displays the top row.
			/// </summary>
			public void DisplayTop()
			{
				_dgview.FirstDisplayedScrollingRowIndex = 0;
			}

			public bool fileMode {
				// Set true if we are running a gcode file
				get { return _filemode; }
				set { _filemode = value; }
			}

		}
		/// <summary>
		/// Handles the CellValueNeeded event of the dgvGcode control. Used
		/// by Virtual Mode=true
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="DataGridViewCellValueEventArgs"/> instance containing the event data.</param>
		private void dgvGcode_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			// Get a set of cell values from our gcode table to paint in the grid view
			GrblGcodeView.gcodeItem item = default(GrblGcodeView.gcodeItem);
			// If this is the row for new records, no values are needed.
			//If e.RowIndex = dgvGcode.RowCount - 1 Then
			//    Return
			//End If

			item = gcodeview.GetGcodeItem(e.RowIndex);
			if ((item == null)) {
				return;
			}

			switch (dgvGcode.Columns[e.ColumnIndex].Name) {
				case "stat":
					e.Value = item.status;
					break;
				case "lineNum":
					e.Value = item.lineNum;
					break;
				case "data":
					e.Value = item.gcode;
					break;
			}

		}
	}
}
