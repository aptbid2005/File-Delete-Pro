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
	public partial class CheckForUpdate
	{

		public CheckForUpdate()
		{
			InitializeComponent();
		}

		private string sUpdatePath;

		private void frmCheckForUpdate_Load(object sender, System.EventArgs e)
		{
			LinkLabel1.Visible = false;
			Label2.Visible = false;
		}

		//private void btnCheckForUpdate_Click(System.Object sender, System.EventArgs e)
		//{
		//	Label2.Text = "Checking for updates...";
		//	Label2.Visible = true;
		//	Application.DoEvents();
		//	using (com.theprodev.www.Common ws = new com.theprodev.www.Common())
		//	{
		//		string AppVer = My.MyApplication.Application.Info.Version.Major + My.MyApplication.Application.Info.Version.Minor + My.MyApplication.Application.Info.Version.Build;
		//		ws.CheckForUpdateCompleted += CheckForUpdateCompleted;
		//		ws.CheckForUpdateAsync(AppVer, My.MyApplication.ProgramID);
		//	}
		//}

		//private void CheckForUpdateCompleted(object sender, com.theprodev.www.CheckForUpdateCompletedEventArgs e)
		//{
		//	try
		//	{
		//		if (e.Result == true)
		//		{
		//			LinkLabel1.Visible = true;
		//			Label2.Visible = false;
		//		}
		//		else
		//		{
		//			Label2.Visible = true;
		//			Label2.Text = "No update is available at this time.";
		//			LinkLabel1.Visible = false;
		//		}
		//	}
		//	catch (System.Web.Services.Protocols.SoapException ex)
		//	{
		//		Label2.Visible = true;
		//	}
		//	Application.DoEvents();
		//}

		private void LinkLabel1_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				using (FolderBrowserDialog fbd = new FolderBrowserDialog())
				{
					fbd.ShowNewFolderButton = true;
					fbd.Tag = "Select the folder you wish to save this update too.";

					DialogResult dr = fbd.ShowDialog();

					if (dr == System.Windows.Forms.DialogResult.OK)
					{
						sUpdatePath = fbd.SelectedPath + "/" + My.MyApplication.Application.Info.Title + " Update.zip";
						System.Uri uri = new System.Uri("http://www.theprodev.com/files/trials/fdp-00.zip");
						System.Net.WebClient wc = new System.Net.WebClient();
						wc.DownloadDataCompleted += DownloadDataCompleted;
						wc.DownloadDataAsync(uri);
					}
				}
			}
			catch (Exception ex)
			{
				Label1.Visible = false;
				MessageBox.Show("Sorry, but we were unable to contact the download server. Please browse to http://www.theprodev.com and download the new Free Version", "Could not connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void DownloadDataCompleted(object sender, System.Net.DownloadDataCompletedEventArgs e)
		{
			System.IO.File.WriteAllBytes(sUpdatePath, e.Result);
			MessageBox.Show("Your download is complete. Unzip and double click the install file to update.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}