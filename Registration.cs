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
	internal partial class Registration
	{

		public Registration()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(System.Object sender, System.EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void btnUnlock_Click(System.Object sender, System.EventArgs e)
		{
			using (com.theprodev.www.Common ws = new com.theprodev.www.Common())
			{
				btnUnlock.Enabled = false;
				btnCancel.Enabled = false;
				ws.ActivateProductV2Completed += ActivateProductComplete;
				ws.ActivateProductV2Async(inEmailAddress.Text.Trim(), inOrderNumber.Text.Trim(), Convert.ToString(My.MyApplication.ProgramID, System.Globalization.CultureInfo.CurrentCulture));
			}
		}

		private void ActivateProductComplete(object sender, com.theprodev.www.ActivateProductV2CompletedEventArgs e)
		{
			if (e.Error == null)
			{
				com.theprodev.www.clsActivation b = e.Result;
				btnUnlock.Enabled = true;
				btnCancel.Enabled = true;

				if (b.OrderValid == 1)
				{
					if (b.Activate == true)
					{
						Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(My.MyApplication.RegKey, true);
						reg.SetValue("KeyCode", b.RegistrationKey.Trim());
						MessageBox.Show(b.Message + Environment.NewLine + Environment.NewLine + "PLEASE RESTART THIS PROGRAM TO COMPLETE THE UNLOCK.", "Program Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
					else
					{
						MessageBox.Show(b.Message, "Unable to unlock program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					}
				}
				else
				{
					MessageBox.Show(b.Message, "Unable to unlock program", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			else
			{
				MessageBox.Show("Could not connect to the Internet. Please make sure your connection is on and active and firewalls will allow our program through.", "No Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				Process.Start("iexplore.exe", My.MyApplication.Application.SiteLink("Registration"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please visit www.theprodev.com for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void frmRegistration_Load(object sender, System.EventArgs e)
		{
			ToolTip1.ToolTipTitle = My.MyApplication.Application.AppInfo;
		}

	}
}