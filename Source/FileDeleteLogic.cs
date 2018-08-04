//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text;

namespace FileDeletePro
{
	internal class FileDeleteLogic
	{

		internal delegate void ProgressEventHandler(string message);
		internal event ProgressEventHandler Progress;

		internal void Delete(string Path)
		{

		}

		/// <summary>
		/// Applies DOD data deletion logic to file then deletes the file forever
		/// </summary>
		/// <param name="FilePathName">File name and path of file to delete</param>
		private void DeleteFile(string FilePathName)
		{
			if (FilePathName.Trim().Length > 0)
			{
				if (System.IO.File.Exists(FilePathName) == true)
				{
					CleanFile(FilePathName);
				}
			}
		}

		private void DeleteFolder(string FolderName)
		{
			string[] dirs = System.IO.Directory.GetDirectories(FolderName);

			foreach (string s in dirs)
			{
				DeleteFolder(s);
			}

			string[] files = System.IO.Directory.GetFiles(FolderName);

			foreach (string f in files)
			{
				CleanFile(f);
			}

		}

		private void CleanFile(string FileName)
		{
			// Three step process
			// Step 1: Write a random character to each bit
			// Step 2: Write another random character to each bit
			// Step 3: Write ranbom characters to each bit

			ProcessStep1(FileName);
			ProcessStep2(FileName);
			ProcessStep3(FileName);
			DeleteFileForever(FileName);

		}

		private void ProcessStep1(string FileName)
		{
			Random Rand = new Random(DateTime.Now.Millisecond);
			ASCIIEncoding c = new ASCIIEncoding();
			byte RandI = c.GetBytes(Microsoft.VisualBasic.Strings.Chr(Rand.Next(33, 255)).ToString())[0];

			System.IO.FileStream fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite);

			try
			{
				byte[] b = new byte[Convert.ToInt32(fs.Length - 1) + 1];

				for (int i = 0; i <= Convert.ToInt32(fs.Length - 1); i++)
				{
					b[i] = RandI;
				}

				fs.Write(b, 0, Convert.ToInt32(fs.Length - 1));
				fs.Flush();
			}
			catch (Exception ex)
			{

			}
			finally
			{
				fs.Close();
			}

		}

		private void ProcessStep2(string FileName)
		{
			Random Rand = new Random(DateTime.Now.Millisecond);
			ASCIIEncoding c = new ASCIIEncoding();
			byte RandI = c.GetBytes(Microsoft.VisualBasic.Strings.Chr(Rand.Next(33, 255)).ToString())[0];

			System.IO.FileStream fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite);
			if (fs.CanRead == true && fs.CanWrite == true)
			{
				try
				{
					byte[] b = new byte[Convert.ToInt32(fs.Length - 1) + 1];

					for (int i = 0; i <= Convert.ToInt32(fs.Length - 1); i++)
					{
						b[i] = RandI;
					}

					fs.Write(b, 0, Convert.ToInt32(fs.Length - 1));
					fs.Flush();
				}
				catch (Exception ex)
				{

				}
				finally
				{
				}
			}
			fs.Close();
		}

		private void ProcessStep3(string FileName)
		{
			System.IO.FileStream fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite);
			try
			{
				byte[] b = new byte[Convert.ToInt32(fs.Length - 1) + 1];

				for (int i = 0; i <= Convert.ToInt32(fs.Length - 1); i++)
				{
					Random Rand = new Random(DateTime.Now.Millisecond);
					ASCIIEncoding c = new ASCIIEncoding();
					b[i] = c.GetBytes(Microsoft.VisualBasic.Strings.Chr(Rand.Next(33, 255)).ToString())[0];
				}

				fs.Write(b, 0, Convert.ToInt32(fs.Length - 1));
				fs.Flush();
			}
			catch (Exception ex)
			{

			}
			finally
			{
				fs.Close();
			}
		}

		private void DeleteFileForever(string FileName)
		{
			System.IO.File.Delete(FileName);
		}

	}
}