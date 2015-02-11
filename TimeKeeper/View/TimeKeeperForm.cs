using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeKeeper
{
	public partial class TimeKeeperForm : Form
	{
		#region Fields

		string[] mDays = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

		#endregion Fields

		#region Events

		#endregion Events

		public TimeKeeperForm()
		{
			InitializeComponent();
			mTodaysDateTimePicker.Value = DateTime.Now;

			// This is just a comment to see how commit works.

		}
	}
}
