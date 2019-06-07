

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using AXONIM.CONSTS;
using System.Threading;
using Ionic.Zip;

namespace ReserveDB
{
	public partial class FDumpDB_SQL : Form
	{
		public FDumpDB_SQL ()
		{
			InitializeComponent ();

			int iSize = Properties.Settings.Default.iSizeX;
			if (iSize > 100)
				Width = iSize;

			string asTemp = Properties.Settings.Default.asPatch;
			if (asTemp.Length > 1)
			{
				TBPatch.Text = asTemp;
				folderBrowserDialog1.SelectedPath = TBPatch.Text;
			}
			asTemp = Properties.Settings.Default.asServer;
			if (asTemp.Length > 1)
				TBServer.Text = asTemp;
			ChBDelSQL.Checked = Properties.Settings.Default.bBDelSQL;
			asTemp = Properties.Settings.Default.asFileSQL;
			if (asTemp.Length > 1)
				TBFileSQL.Text = asTemp;
		}
		//_________________________________________________________________________
		private void BReserved_Click (object sender, EventArgs e)
		{
			timer1.Start ();
			RunBackup (TBServer.Text, TBDB.Text, TBLogin.Text, TBPassw.Text, TBPatch.Text, TBFileSQL.Text);
		}
		//_________________________________________________________________________

		string asFileName;

		public bool RunBackup (string server, string db, string login, string pass, string asPatch, string asFile)
		{
			Properties.Settings.Default.asPatch = TBPatch.Text;
			Properties.Settings.Default.asServer = TBServer.Text;
			Properties.Settings.Default.asFileSQL = TBFileSQL.Text;
			Properties.Settings.Default.bBDelSQL = ChBDelSQL.Checked;

			asFileName = asFile + DateTime.Now.ToShortDateString () + "_dump.sql";
			string asFileFull = asPatch + @"\" + asFileName;

			ThreadPool.QueueUserWorkItem ((o) =>
			{
				Process Proc = new Process ();
				try
				{
					string asOutput;
					Proc.StartInfo.FileName = "mysqldump.exe";
					//Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Proc.StartInfo.CreateNoWindow = true;
					Proc.StartInfo.RedirectStandardInput = false;
					Proc.StartInfo.RedirectStandardOutput = true;
					Proc.StartInfo.UseShellExecute = false;
					string asPas = string.IsNullOrEmpty (pass) ? "" : "-p" + pass;
					Proc.StartInfo.Arguments = $"-u{login} {asPas} -h{server} {db}";
					//@"--defaults - file = '{0}'--user = {1} {4} --host = {2}--protocol = tcp--port = 3306--default- character - set = utf8--skip - triggers '{3}'",
					//@"--defaults - file = '{0}' -u{1} {4} -h{2} {3} --protocol = tcp--port = 3306--default- character - set = utf8--skip",
					//file, login, server, db, string.IsNullOrEmpty (pass) ? "" : "-p" + pass							
					Proc.Start ();
					asOutput = Proc.StandardOutput.ReadToEnd ();
					Proc.WaitForExit ();
					if (ChBDelSQL.Checked == false)
						File.WriteAllText (asFileFull, asOutput, Global.EncodingCurr);
					ZipSql (asOutput, asFileFull);
				}
				catch (Exception e)
				{
					MessageBox.Show (e.Message, "Dump DB");
				}
				finally
				{
					Proc.Close ();
					timer1.Stop ();
					MessShow ();
				}
			}, null);
			return true;
		}
		//___________________________________________________________________________
		private void ZipSql (string asOutput, string asFulllPathName)
		{
			using (ZipFile zip = new ZipFile ())
			{
				string asFileName = Path.GetFileName (asFulllPathName);
				//Encoding Encdng = Encoding.Unicode;
				zip.AddEntry (asFileName, asOutput);
				//zip.AddFile (FilesToPack.ElementAt (iNumFl).Value.asNameFull, "");   //zip.AddFile (FilesToPack.ElementAt (iNumFl).Value.asName);
				zip.Save (asFulllPathName.Replace ("sql", "zip"));//zip.Save (FilesToPack.ElementAt (iiNumFlValue.asName.Replace (asExtLog, "zip"));
			}
		}
		//___________________________________________________________________________

		public delegate void DMessageShow ();
		DMessageShow MS;

		private void OutToTB ()
		{			
			LMess.Text = $"Файл {Path.GetFileNameWithoutExtension (asFileName)} создан";
		}
		//___________________________________________________________________________
		public void MessShow ()
		{
			MS = OutToTB;
			Invoke (MS);
		}
		//_________________________________________________________________________
		private void Form1_FormClosed (object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Save ();
		}
		//_________________________________________________________________________
		private void Button1_Click (object sender, EventArgs e)
		{
			Close ();
		}
		//_________________________________________________________________________

		int iCountTimes;
		private void Timer1_Tick (object sender, EventArgs e)
		{
			++iCountTimes;
			LMess.Text = iCountTimes.ToString ();
		}
		//_________________________________________________________________________
		private void BOpenFolder_Click (object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog () == DialogResult.OK)
			{
				TBPatch.Text = folderBrowserDialog1.SelectedPath;
			}
		}
		//_________________________________________________________________________
		private void FDumpDB_SQL_SizeChanged (object sender, EventArgs e)
		{
			Properties.Settings.Default.iSizeX = Width;
		}
		//_________________________________________________________________________
		private void PSetups_MouseEnter (object sender, EventArgs e)
		{
			PSetups.Height = 148;
		}
		//.........................................................................
		private void Panel1_MouseEnter (object sender, EventArgs e)
		{
			PSetups.Height = 15;
		}
	}
}
