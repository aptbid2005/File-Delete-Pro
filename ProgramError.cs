//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace FileDeletePro
{
	internal partial class ProgramError
	{

		public ProgramError()
		{
			InitializeComponent();
		}

		private Exception mDataError;
		internal Exception DataError
		{
			get
			{
				return mDataError;
			}
			set
			{
				mDataError = value;
			}
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			ReportError();
		}

		private void frmError_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
		{
			ReportError();
		}

		private void ReportError()
		{
			using (com.theprodev.www.Common ws = new com.theprodev.www.Common())
			{
				System.Net.IPAddress[] IP = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());
				string IPAddresses = "";
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of UBound(IP) for every iteration:
				int tempVar = IP.GetUpperBound(0);
				for (int i = 0; i <= tempVar; i++)
				{
					IPAddresses += IP[i].ToString();

					if (!(i == IP.GetUpperBound(0)))
					{
						IPAddresses += "<br />";
					}
				}
				ws.ReportErrorDesktopErrorAsync(DataError.Message + Environment.NewLine + inEmail.Text.Trim(), DataError.StackTrace, DataError.ToString(), My.Computer.Info.OSFullName, IPAddresses, My.MyApplication.Application.AppInfo);
			}
			MessageBox.Show("Thank you for reporting this error and helping us make our software better.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}