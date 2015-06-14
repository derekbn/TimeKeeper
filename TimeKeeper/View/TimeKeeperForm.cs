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

		decimal mTotalTime;

		decimal mTotalRegTime;

		decimal mTotalOverTime;

		#endregion Fields

		#region Events

		#endregion Events

		#region Methods

		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			TotalTime();
			mTotalTextBox.Text = mTotalTime.ToString();

			var timeLeft = mMaxTimeNumericUpDown.Value - mTotalTime;

			mTimeLeftTextBox.Text = timeLeft.ToString();
		}

		public TimeKeeperForm()
		{
			InitializeComponent();
			mTodaysDateTimePicker.Value = DateTime.Now;
		}

		public void TotalTime()
		{
			decimal regTotal = 0;
			decimal overTotal = 0;
			foreach (Control control in mMainTimeEntryTableLayoutPanel.Controls)
			{
				if (string.Equals((string)(control.Tag), "Regular", StringComparison.OrdinalIgnoreCase))
				{
					regTotal += ((NumericUpDown)control).Value;
				}
				if (string.Equals((string)(control.Tag), "Overtime", StringComparison.OrdinalIgnoreCase))
				{
					overTotal += ((NumericUpDown)control).Value;
				}
			}

			mTotalRegTime = regTotal;
			mTotalOverTime = overTotal;
			mTotalTime = regTotal + overTotal;
		}

		#endregion Methods
	}
}
