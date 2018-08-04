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
	public partial class Suggestion
	{

		public Suggestion()
		{
			InitializeComponent();
		}

		private void Button2_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
		}

		//private void Button1_Click(System.Object sender, System.EventArgs e)
		//{
		//	if (!(inSuggestion.Text.Length == 0))
		//	{
		//		Button1.Enabled = false;
		//		Application.DoEvents();
		//		using (com.theprodev.www.Common ws = new com.theprodev.www.Common())
		//		{
		//			string AppVer = My.MyApplication.Application.Info.Version.Major + My.MyApplication.Application.Info.Version.Minor + My.MyApplication.Application.Info.Version.Build;
		//			ws.MakeASuggestionCompleted += MakeSuggestionComplete;
		//			ws.MakeASuggestionAsync(AppVer, My.MyApplication.Application.Info.Title, inSuggestion.Text.Trim() + "<br />" + inEmail.Text.Trim(), inName.Text.Trim());
		//		}
		//	}
		//	else
		//	{
		//		MessageBox.Show("You must provide a suggestion.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		//	}
		//}

		private void MakeSuggestionComplete(object sender, com.theprodev.www.MakeASuggestionCompletedEventArgs e)
		{
			inName.Text = "";
			inSuggestion.Text = "";
			Button1.Enabled = true;
			Application.DoEvents();
			MessageBox.Show("Thank you for your suggestion.", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

	}
}