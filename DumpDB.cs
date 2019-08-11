

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
		int iCountTimes;

		//wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww

		public FDumpDB_SQL()
		{
			InitializeComponent();

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

			ChToMem.CheckedChanged -= ChToMem_CheckedChanged;
			ChToMem.Checked = Properties.Settings.Default.bToMem;
			ChToMem.CheckedChanged += ChToMem_CheckedChanged;
		}
		//_________________________________________________________________________
		private void BReserved_Click(object sender, EventArgs e)
		{
			timer1.Start();
			iCountTimes = 0;
			RunBackup(TBServer.Text, TBDB.Text, TBLogin.Text, TBPassw.Text, TBPatch.Text, TBFileSQL.Text);
		}
		//_________________________________________________________________________

		string asFileName;

		public bool RunBackup(string asServer, string asDB, string asLogin, string asParol, string asPut, string asFile)
		{
			Properties.Settings.Default.asPatch = TBPatch.Text;
			Properties.Settings.Default.asServer = TBServer.Text;
			Properties.Settings.Default.asFileSQL = TBFileSQL.Text;
			Properties.Settings.Default.bBDelSQL = ChBDelSQL.Checked;

			asFileName = asFile + "_" + DateTime.Now.ToShortDateString() + "_dump.sql";
			string asFileFull = asPut + @"\" + asFileName;

			ThreadPool.QueueUserWorkItem((o) =>
		 {
			 Process Proc = new Process ();
			 string asOutput = string.Empty;
			 try
			 {
				 Proc.StartInfo.FileName = "mysqldump.exe";
				 Proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				 Proc.StartInfo.CreateNoWindow = true;
				 Proc.StartInfo.RedirectStandardInput = false;
				 Proc.StartInfo.RedirectStandardOutput = ChToMem.Checked;
				 Proc.StartInfo.UseShellExecute = false;

				 string asPas = string.IsNullOrEmpty (asParol) ? "" : "-p" + asParol;
				 string asArguments = $"-u{asLogin} {asPas} -h{asServer} {asDB} -v --insert-ignore --skip-lock-tables --single-transaction=TRUE";
				 //@"--defaults - file = '{0}'--user = {1} {4} --host = {2}--protocol = tcp--port = 3306--default- character - set = utf8--skip - triggers '{3}'",
				 //@"--defaults - file = '{0}' -u{1} {4} -h{2} {3} --protocol = tcp--port = 3306--default- character - set = utf8--skip",
				 //file, login, server, db, string.IsNullOrEmpty (pass) ? "" : "-p" + pass		
				 if (ChToMem.Checked == false)
					 asArguments += " > " + asFileFull;
				 Proc.StartInfo.Arguments = asArguments;

				 Proc.Start();
				 if (ChToMem.Checked)
					 asOutput = Proc.StandardOutput.ReadToEnd();

				 Proc.WaitForExit();
				 if (ChBDelSQL.Checked == false && ChToMem.Checked)
					 File.WriteAllText(asFileFull, asOutput, Global.EncodingCurr);
				 ZipSql(asOutput, asFileFull);
					// Удаляем sql, если писался в файл и задано удаление с диска
					if (ChBDelSQL.Checked && !ChToMem.Checked)
				 {
					 File.Delete(asFileFull);
				 }
				 MessShow("");
			 }
			 catch (Exception e)
			 {
				 MessageBox.Show (e.Message, "Dump DB");
				 MessShow ("Файл не создан");
			 }
			 finally
			 {
				 Proc.Close();
				 timer1.Stop();
				 asOutput = "";
			 }
		 }, null);
			return true;
		}
		//___________________________________________________________________________
		private void ZipSql(string asOutput, string asFulllPathName)
		{
			using (ZipFile zip = new ZipFile())
			{
				if (ChToMem.Checked)
				{
					string asFileName = Path.GetFileName (asFulllPathName);
					//Encoding Encdng = Encoding.Unicode;
					zip.AddEntry(asFileName, asOutput);
				}
				else
				{
					zip.AddFile(asFulllPathName);
				}
				//zip.AddFile (FilesToPack.ElementAt (iNumFl).Value.asNameFull, "");   //zip.AddFile (FilesToPack.ElementAt (iNumFl).Value.asName);
				zip.Save(asFulllPathName.Replace("sql", "zip"));//zip.Save (FilesToPack.ElementAt (iiNumFlValue.asName.Replace (asExtLog, "zip"));
			}
		}
		//___________________________________________________________________________

		public delegate void DMessageShow(string asMess);
		DMessageShow MS;

		private void OutToTB(string asMess)
		{
			if (asMess.Length == 0)
				LMess.Text = $"Файл {Path.GetFileNameWithoutExtension(asFileName)} создан";
			else LMess.Text = asMess;
		}
		//___________________________________________________________________________
		public void MessShow(string asMess)
		{
			MS = OutToTB;
			Invoke(MS, asMess);
		}
		//_________________________________________________________________________
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.Save();
		}
		//_________________________________________________________________________
		private void Button1_Click(object sender, EventArgs e)
		{
			Close();
		}
		//_________________________________________________________________________
		private void Timer1_Tick(object sender, EventArgs e)
		{
			++iCountTimes;
			LMess.Text = iCountTimes.ToString() + " сек";
		}
		//_________________________________________________________________________
		private void BOpenFolder_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				TBPatch.Text = folderBrowserDialog1.SelectedPath;
			}
		}
		//_________________________________________________________________________
		private void FDumpDB_SQL_SizeChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.iSizeX = Width;
		}
		//_________________________________________________________________________
		private void PSetups_MouseEnter(object sender, EventArgs e)
		{
			PSetups.Height = 148;
		}
		//.........................................................................
		private void Panel1_MouseEnter(object sender, EventArgs e)
		{
			PSetups.Height = 15;
		}
		//_________________________________________________________________________
		private void ChToMem_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.bToMem = ChToMem.Checked;
		}
	}
}
