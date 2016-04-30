using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
// Imported from
// http://www.codeproject.com/Articles/5289/A-Simple-Auto-Repeat-Button-on-VB-NET
// Thank you Daniel
// 

using System.Windows.Forms;
namespace RepeatButton
{


	public class RepeatButton : System.Windows.Forms.Button
	{

		public RepeatButton()
		{
			MouseUp += RepeatButton_MouseUp;
			MouseDown += RepeatButton_MouseDown;
			myTimer.Tick += OnTimer;
			myTimer.Enabled = false;
		}

		public Timer myTimer = new Timer();
		public int Interval {
			get { return myTimer.Interval; }

			set { myTimer.Interval = value; }
		}

		private void OnTimer(object sender, EventArgs e)
		{
			//fire off a click on each timer tick
			OnClick(EventArgs.Empty);
		}

		private void RepeatButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//turn on the timer 
			myTimer.Enabled = true;
		}

		private void RepeatButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// turn off the timer 
			myTimer.Enabled = false;
		}

	}
}

