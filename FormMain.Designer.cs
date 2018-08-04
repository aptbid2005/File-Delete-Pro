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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class FormMain : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.GetFullVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CheckForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MakeASuggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.VisitOurWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LikeUsOnFacebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CheckUsOutOnYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.FollowMeOnTwitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.FileToolStripMenuItem, this.HelpToolStripMenuItem, this.GetFullVersionToolStripMenuItem});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.MenuStrip1.Size = new System.Drawing.Size(784, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//FileToolStripMenuItem
			//
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.FileToolStripMenuItem.Text = "File";
			//
			//HelpToolStripMenuItem
			//
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.AboutThisProgramToolStripMenuItem, this.ToolStripSeparator2, this.CheckForUpdatesToolStripMenuItem, this.MakeASuggestionToolStripMenuItem, this.ToolStripSeparator1, this.VisitOurWebsiteToolStripMenuItem, this.LikeUsOnFacebookToolStripMenuItem, this.CheckUsOutOnYouTubeToolStripMenuItem, this.FollowMeOnTwitterToolStripMenuItem});
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			//
			//GetFullVersionToolStripMenuItem
			//
			this.GetFullVersionToolStripMenuItem.Name = "GetFullVersionToolStripMenuItem";
			this.GetFullVersionToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.GetFullVersionToolStripMenuItem.Text = "Get Full Version";
			//
			//ToolStripSeparator1
			//
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(208, 6);
			//
			//ToolStripSeparator2
			//
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(208, 6);
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Image = FileDeletePro.Properties.Resources.x;
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			//
			//AboutThisProgramToolStripMenuItem
			//
			this.AboutThisProgramToolStripMenuItem.Image = FileDeletePro.Properties.Resources.root;
			this.AboutThisProgramToolStripMenuItem.Name = "AboutThisProgramToolStripMenuItem";
			this.AboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.AboutThisProgramToolStripMenuItem.Text = "About this program";
			//
			//CheckForUpdatesToolStripMenuItem
			//
			this.CheckForUpdatesToolStripMenuItem.Image = FileDeletePro.Properties.Resources.check;
			this.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem";
			this.CheckForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.CheckForUpdatesToolStripMenuItem.Text = "Check for updates";
			//
			//MakeASuggestionToolStripMenuItem
			//
			this.MakeASuggestionToolStripMenuItem.Image = FileDeletePro.Properties.Resources.email_icon_16x16;
			this.MakeASuggestionToolStripMenuItem.Name = "MakeASuggestionToolStripMenuItem";
			this.MakeASuggestionToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.MakeASuggestionToolStripMenuItem.Text = "Make a suggestion";
			//
			//VisitOurWebsiteToolStripMenuItem
			//
			this.VisitOurWebsiteToolStripMenuItem.Image = FileDeletePro.Properties.Resources.TPD_Starburst_16x16;
			this.VisitOurWebsiteToolStripMenuItem.Name = "VisitOurWebsiteToolStripMenuItem";
			this.VisitOurWebsiteToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.VisitOurWebsiteToolStripMenuItem.Text = "Visit our website";
			//
			//LikeUsOnFacebookToolStripMenuItem
			//
			this.LikeUsOnFacebookToolStripMenuItem.Image = FileDeletePro.Properties.Resources.Facebook_icon__1_;
			this.LikeUsOnFacebookToolStripMenuItem.Name = "LikeUsOnFacebookToolStripMenuItem";
			this.LikeUsOnFacebookToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.LikeUsOnFacebookToolStripMenuItem.Text = "Like us on Facebook";
			//
			//CheckUsOutOnYouTubeToolStripMenuItem
			//
			this.CheckUsOutOnYouTubeToolStripMenuItem.Image = FileDeletePro.Properties.Resources.Youtube_icon;
			this.CheckUsOutOnYouTubeToolStripMenuItem.Name = "CheckUsOutOnYouTubeToolStripMenuItem";
			this.CheckUsOutOnYouTubeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.CheckUsOutOnYouTubeToolStripMenuItem.Text = "Check us out on YouTube";
			//
			//FollowMeOnTwitterToolStripMenuItem
			//
			this.FollowMeOnTwitterToolStripMenuItem.Image = FileDeletePro.Properties.Resources.twitter_newbird_boxed_blueonwhite;
			this.FollowMeOnTwitterToolStripMenuItem.Name = "FollowMeOnTwitterToolStripMenuItem";
			this.FollowMeOnTwitterToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
			this.FollowMeOnTwitterToolStripMenuItem.Text = "Follow me on Twitter";
			//
			//FormMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.MenuStrip1;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(FormMain_Load);
			AboutThisProgramToolStripMenuItem.Click += new System.EventHandler(AboutThisProgramToolStripMenuItem_Click);
			CheckForUpdatesToolStripMenuItem.Click += new System.EventHandler(CheckForUpdatesToolStripMenuItem_Click);
			MakeASuggestionToolStripMenuItem.Click += new System.EventHandler(MakeASuggestionToolStripMenuItem_Click);
			VisitOurWebsiteToolStripMenuItem.Click += new System.EventHandler(VisitOurWebsiteToolStripMenuItem_Click);
			LikeUsOnFacebookToolStripMenuItem.Click += new System.EventHandler(LikeUsOnFacebookToolStripMenuItem_Click);
			CheckUsOutOnYouTubeToolStripMenuItem.Click += new System.EventHandler(CheckUsOutOnYouTubeToolStripMenuItem_Click);
			FollowMeOnTwitterToolStripMenuItem.Click += new System.EventHandler(FollowMeOnTwitterToolStripMenuItem_Click);
			ExitToolStripMenuItem.Click += new System.EventHandler(ExitToolStripMenuItem_Click);
			GetFullVersionToolStripMenuItem.Click += new System.EventHandler(GetFullVersionToolStripMenuItem_Click);
		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutThisProgramToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
		internal System.Windows.Forms.ToolStripMenuItem CheckForUpdatesToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem MakeASuggestionToolStripMenuItem;
		internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
		internal System.Windows.Forms.ToolStripMenuItem VisitOurWebsiteToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem LikeUsOnFacebookToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem CheckUsOutOnYouTubeToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem FollowMeOnTwitterToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem GetFullVersionToolStripMenuItem;

		private static FormMain _DefaultInstance;
		public static FormMain DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new FormMain();

				return _DefaultInstance;
			}
		}
	}

}