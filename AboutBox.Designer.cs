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
	public partial class AboutBox : System.Windows.Forms.Form
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

		internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
		internal System.Windows.Forms.Label LabelProductName;
		internal System.Windows.Forms.Label LabelVersion;
		internal System.Windows.Forms.Label LabelCompanyName;
		internal System.Windows.Forms.TextBox TextBoxDescription;
		internal System.Windows.Forms.Button OKButton;
		internal System.Windows.Forms.Label LabelCopyright;

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
			this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.LabelProductName = new System.Windows.Forms.Label();
			this.LabelVersion = new System.Windows.Forms.Label();
			this.LabelCopyright = new System.Windows.Forms.Label();
			this.LabelCompanyName = new System.Windows.Forms.Label();
			this.TextBoxDescription = new System.Windows.Forms.TextBox();
			this.OKButton = new System.Windows.Forms.Button();
			this.TableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			//
			//TableLayoutPanel
			//
			this.TableLayoutPanel.ColumnCount = 1;
			this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.0F));
			this.TableLayoutPanel.Controls.Add(this.LabelProductName, 0, 0);
			this.TableLayoutPanel.Controls.Add(this.LabelVersion, 0, 1);
			this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 0, 2);
			this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 0, 3);
			this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 0, 4);
			this.TableLayoutPanel.Controls.Add(this.OKButton, 0, 5);
			this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel.Location = new System.Drawing.Point(9, 9);
			this.TableLayoutPanel.Name = "TableLayoutPanel";
			this.TableLayoutPanel.RowCount = 6;
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
			this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0F));
			this.TableLayoutPanel.Size = new System.Drawing.Size(396, 258);
			this.TableLayoutPanel.TabIndex = 0;
			//
			//LabelProductName
			//
			this.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelProductName.Location = new System.Drawing.Point(6, 0);
			this.LabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelProductName.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelProductName.Name = "LabelProductName";
			this.LabelProductName.Size = new System.Drawing.Size(387, 17);
			this.LabelProductName.TabIndex = 0;
			this.LabelProductName.Text = "Product Name";
			this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//LabelVersion
			//
			this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelVersion.Location = new System.Drawing.Point(6, 25);
			this.LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new System.Drawing.Size(387, 17);
			this.LabelVersion.TabIndex = 0;
			this.LabelVersion.Text = "Version";
			this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//LabelCopyright
			//
			this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCopyright.Location = new System.Drawing.Point(6, 50);
			this.LabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelCopyright.Name = "LabelCopyright";
			this.LabelCopyright.Size = new System.Drawing.Size(387, 17);
			this.LabelCopyright.TabIndex = 0;
			this.LabelCopyright.Text = "Copyright";
			this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//LabelCompanyName
			//
			this.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LabelCompanyName.Location = new System.Drawing.Point(6, 75);
			this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
			this.LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
			this.LabelCompanyName.Name = "LabelCompanyName";
			this.LabelCompanyName.Size = new System.Drawing.Size(387, 17);
			this.LabelCompanyName.TabIndex = 0;
			this.LabelCompanyName.Text = "Company Name";
			this.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//TextBoxDescription
			//
			this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBoxDescription.Location = new System.Drawing.Point(6, 103);
			this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.TextBoxDescription.Multiline = true;
			this.TextBoxDescription.Name = "TextBoxDescription";
			this.TextBoxDescription.ReadOnly = true;
			this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TextBoxDescription.Size = new System.Drawing.Size(387, 123);
			this.TextBoxDescription.TabIndex = 0;
			this.TextBoxDescription.TabStop = false;
			this.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text");
			//
			//OKButton
			//
			this.OKButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Location = new System.Drawing.Point(318, 232);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 0;
			this.OKButton.Text = "&OK";
			//
			//AboutBox
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.OKButton;
			this.ClientSize = new System.Drawing.Size(414, 276);
			this.Controls.Add(this.TableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.Padding = new System.Windows.Forms.Padding(9);
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutBox";
			this.TableLayoutPanel.ResumeLayout(false);
			this.TableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(AboutBox_Load);
			OKButton.Click += new System.EventHandler(OKButton_Click);
		}

	}

}