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
	public partial class Suggestion : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suggestion));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.inName = new System.Windows.Forms.TextBox();
			this.inSuggestion = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button2 = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.inEmail = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			resources.ApplyResources(this.Label1, "Label1");
			this.Label1.Name = "Label1";
			//
			//Label2
			//
			resources.ApplyResources(this.Label2, "Label2");
			this.Label2.Name = "Label2";
			//
			//inName
			//
			resources.ApplyResources(this.inName, "inName");
			this.inName.Name = "inName";
			//
			//inSuggestion
			//
			this.inSuggestion.AcceptsReturn = true;
			this.inSuggestion.AcceptsTab = true;
			resources.ApplyResources(this.inSuggestion, "inSuggestion");
			this.inSuggestion.Name = "inSuggestion";
			//
			//Button1
			//
			resources.ApplyResources(this.Button1, "Button1");
			this.Button1.Name = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			resources.ApplyResources(this.Button2, "Button2");
			this.Button2.Name = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			resources.ApplyResources(this.Label3, "Label3");
			this.Label3.Name = "Label3";
			//
			//Label4
			//
			resources.ApplyResources(this.Label4, "Label4");
			this.Label4.Name = "Label4";
			//
			//inEmail
			//
			resources.ApplyResources(this.inEmail, "inEmail");
			this.inEmail.Name = "inEmail";
			//
			//Label5
			//
			resources.ApplyResources(this.Label5, "Label5");
			this.Label5.Name = "Label5";
			//
			//Suggestion
			//
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.inEmail);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Button2);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.inSuggestion);
			this.Controls.Add(this.inName);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Label3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Suggestion";
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			Button2.Click += new System.EventHandler(Button2_Click);
			//Button1.Click += new System.EventHandler(Button1_Click);
		}
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox inName;
		internal System.Windows.Forms.TextBox inSuggestion;
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox inEmail;
		internal System.Windows.Forms.Label Label5;

		private static Suggestion _DefaultInstance;
		public static Suggestion DefaultInstance
		{
			get
			{
				if (_DefaultInstance == null || _DefaultInstance.IsDisposed)
					_DefaultInstance = new Suggestion();

				return _DefaultInstance;
			}
		}
	}

}