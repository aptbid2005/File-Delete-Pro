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
	public partial class FormMain
	{

		public FormMain()
		{
			InitializeComponent();
		}

		private void FormMain_Load(object sender, System.EventArgs e)
		{
			Text = My.MyApplication.Application.AppInfo;
		}

		private void AboutThisProgramToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			using (AboutBox frm = new AboutBox())
			{
				frm.ShowDialog();
			}
		}

		private void CheckForUpdatesToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			using (CheckForUpdate frm = new CheckForUpdate())
			{
				frm.ShowDialog();
			}
		}

		private void MakeASuggestionToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			using (Suggestion frm = new Suggestion())
			{
				frm.ShowDialog();
			}
		}

		private void VisitOurWebsiteToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("iexplore.exe", My.MyApplication.Application.SiteLink("MainMenu"));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please visit www.theprodev.com for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void LikeUsOnFacebookToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{

		}

		private void CheckUsOutOnYouTubeToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("iexplore.exe", "http://www.youtube.com/aptbid2007");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please visit www.youtube.com/aptbid2007 for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void FollowMeOnTwitterToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start("iexplore.exe", "http://twitter.com/jasonnowicki");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Please visit twitter.com/jasonnowicki for more information", "Error opening webpage", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void ExitToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void GetFullVersionToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
		{
			using (Registration frm = new Registration())
			{
				frm.ShowDialog();
			}
		}

	}
}