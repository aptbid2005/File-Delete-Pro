﻿//INSTANT C# NOTE: Formerly VB project-level imports:
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
	public partial class CheckForUpdate : System.Windows.Forms.Form
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForUpdate));
			this.Label1 = new System.Windows.Forms.Label();
			this.btnCheckForUpdate = new System.Windows.Forms.Button();
			this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
			this.Label2 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//Label1
			//
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			//
			//btnCheckForUpdate
			//
			resources.ApplyResources(this.btnCheckForUpdate, "btnCheckForUpdate");
			this.btnCheckForUpdate.Name = "btnCheckForUpdate";
			this.btnCheckForUpdate.UseVisualStyleBackColor = true;
			//
			//LinkLabel1
			//
			resources.ApplyResources(this.LinkLabel1, "LinkLabel1");
			this.LinkLabel1.Name = "LinkLabel1";
			this.LinkLabel1.TabStop = true;
			//
			//Label2
			//
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			//
			//Button1
			//
			resources.ApplyResources(this.Button1, "Button1");
			this.Button1.Name = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//CheckForUpdate
			//
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.LinkLabel1);
			this.Controls.Add(this.btnCheckForUpdate);
			this.Controls.Add(this.Label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CheckForUpdate";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(frmCheckForUpdate_Load);
			//btnCheckForUpdate.Click += new System.EventHandler(btnCheckForUpdate_Click);
			LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(LinkLabel1_LinkClicked);
			Button1.Click += new System.EventHandler(Button1_Click);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Button btnCheckForUpdate;
		internal System.Windows.Forms.LinkLabel LinkLabel1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button Button1;
	}

}