﻿//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using System.Web;

namespace FileDeletePro
{
	namespace TheProDev
	{
		public static class clsRegistration
		{

			private static bool _Registered = false;
			internal static bool Registered
			{
				get
				{
					return _Registered;
				}
			}

			internal static bool ValidateRegistration(string EKC = "")
			{
				bool tempValidateRegistration = false;
				//      FT    FTM    PID         ATM          LC
				//   filetime:mod:programid:AnswertoMod7:programID*AnswertoMod*10073

				try
				{
					string KC = "";

					if (EKC.Length == 0)
					{
						Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(My.MyApplication.RegKey);
						KC = System.Text.Encoding.Default.GetString(Convert.FromBase64String(reg.GetValue("KeyCode").ToString()));
					}
					else
					{
						KC = System.Text.Encoding.Default.GetString(Convert.FromBase64String(EKC));
					}

					if (KC.Length > 0)
					{
						string[] str = KC.Split(':');
						long FT = long.Parse(str[0]);
						long FTM = long.Parse(str[1]);
						int PID = Convert.ToInt32(str[2]);
						long ATM = long.Parse(str[3]);
						int LC = Convert.ToInt32(str[4]);

						if (My.MyApplication.ProgramID == PID)
						{

							int testMod = Convert.ToInt32(FT % FTM);
							if (testMod == ATM)
							{

								if (((PID * testMod) * 10073) == LC)
								{
									if (EKC.Length == 0)
									{
										_Registered = true;
									}
									else
									{
										tempValidateRegistration = true;
									}
								}

							}
						}

					}

				}
				catch (Exception ex)
				{

				}

				return tempValidateRegistration;
			}

		}
	}
}