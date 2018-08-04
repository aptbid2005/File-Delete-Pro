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
	namespace My
	{

		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{
			internal const int ProgramID = 28;
			internal const string RegKey = "Software\\TPD\\FDP";

			private string sUpdatePath;

			private string mKeyCode;
			internal string KeyCode
			{
				get
				{
					return mKeyCode;
				}
				set
				{
					mKeyCode = value;
				}
			}

			internal string AppInfo
			{
				get
				{
					return My.MyApplication.Application.Info.Title + " v" + My.MyApplication.Application.Info.Version.Major + "." + My.MyApplication.Application.Info.Version.Minor + "." + My.MyApplication.Application.Info.Version.Build;
				}
			}

			internal string SiteLink(string Location)
			{
				return "http://www.theprodev.com/28/tpd-file-delete-pro.aspx?ref=" + string.Concat(new string[] {Location, "&ver=", My.MyApplication.Application.Info.Version.Major.ToString(), My.MyApplication.Application.Info.Version.Minor.ToString(), My.MyApplication.Application.Info.Version.Build.ToString()});
			}

			private void MyApplication_Startup(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
			{
				LoadSettings();
				TheProDev.clsRegistration.ValidateRegistration();
			}

			private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
			{
				if (e.Exception != null)
				{
					ProgramError.DefaultInstance.DataError = e.Exception;
					ProgramError.DefaultInstance.ShowDialog();
				}
			}

			private void LoadSettings()
			{
				Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);

				if (reg == null)
				{
					reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(RegKey, Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree);
				}

				// Key Code
				if (reg.GetValue("KeyCode") == null)
				{
					reg.SetValue("KeyCode", "");
					KeyCode = "";
				}
				else
				{
					KeyCode = reg.GetValue("KeyCode").ToString();

					if (KeyCode.Length > 0)
					{
						try
						{
							using (com.theprodev.www.Common ws = new com.theprodev.www.Common())
							{
								ws.ValidateEKCCompleted += ValidateEKCComplete;
								ws.ValidateEKCAsync(KeyCode);
							}
						}
						catch (System.Net.Sockets.SocketException ex)
						{

						}
					}
				}

				//CheckForUpdate();
			}

			private void ValidateEKCComplete(object sender, com.theprodev.www.ValidateEKCCompletedEventArgs e)
			{
				if (e.Error == null)
				{
					if (e.Result == false)
					{
						Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(RegKey, true);
						reg.SetValue("KeyCode", "");
					}
				}
			}

			//private void CheckForUpdate()
			//{
			//	using (com.theprodev.www.Common ws = new com.theprodev.www.Common())
			//	{
			//		string AppVer = Application.Info.Version.Major + My.MyApplication.Application.Info.Version.Minor + My.MyApplication.Application.Info.Version.Build;
			//		ws.CheckForUpdateCompleted += CheckForUpdateCompleted;
			//		ws.CheckForUpdateAsync(AppVer, MyApplication.ProgramID);
			//	}
			//}

			private void CheckForUpdateCompleted(object sender, com.theprodev.www.CheckForUpdateCompletedEventArgs e)
			{
				if (e.Error == null)
				{
					if (e.Result == true)
					{
						DialogResult mbr = MessageBox.Show("An update to this program is available would you like to download it?", My.MyApplication.Application.Info.Title + " - Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
						if (mbr == DialogResult.Yes)
						{
							try
							{
								using (FolderBrowserDialog fbd = new FolderBrowserDialog())
								{
									fbd.ShowNewFolderButton = true;
									fbd.Description = "Select the folder you wish to save this update to.";

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
								MessageBox.Show("Sorry, but we were unable to contact the download server. Please browse to http://www.theprodev.com and download the new Free Version", "Could not connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
						}
					}
				}
			}

			private void DownloadDataCompleted(object sender, System.Net.DownloadDataCompletedEventArgs e)
			{
				System.IO.File.WriteAllBytes(sUpdatePath, e.Result);
				MessageBox.Show("Your download is complete. Unzip and double click the install file to update.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

			[STAThread]
			static void Main(string[] args)
			{
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
				MyApp = new MyApplication();
				MyApp.Run(args);
			}


//INSTANT C# NOTE: Converted event handler wireups:
			private bool EventsSubscribed = false;
			private void SubscribeToEvents()
			{
				if (EventsSubscribed)
					return;
				else
					EventsSubscribed = true;

				this.Startup += MyApplication_Startup;
				this.UnhandledException += MyApplication_UnhandledException;
			}

		}


	}
}