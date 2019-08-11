namespace ReserveDB
{
	partial class FDumpDB_SQL
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDumpDB_SQL));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.TBDB = new System.Windows.Forms.TextBox();
			this.TBLogin = new System.Windows.Forms.TextBox();
			this.TBPassw = new System.Windows.Forms.TextBox();
			this.TBServer = new System.Windows.Forms.TextBox();
			this.TBPatch = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TBFileSQL = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.ChBDelSQL = new System.Windows.Forms.CheckBox();
			this.LMess = new System.Windows.Forms.Label();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.PSetups = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.BOpenFolder = new System.Windows.Forms.Button();
			this.BReserved = new System.Windows.Forms.Button();
			this.BClose = new System.Windows.Forms.Button();
			this.ChToMem = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.PSetups.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "БД";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 85);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Пароль";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 118);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Сервер";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 53);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Логин";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(8, 20);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 18);
			this.label5.TabIndex = 4;
			this.label5.Text = "Расположение";
			// 
			// TBDB
			// 
			this.TBDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBDB.ForeColor = System.Drawing.Color.Gray;
			this.TBDB.Location = new System.Drawing.Point(116, 14);
			this.TBDB.Margin = new System.Windows.Forms.Padding(5);
			this.TBDB.Name = "TBDB";
			this.TBDB.Size = new System.Drawing.Size(224, 26);
			this.TBDB.TabIndex = 5;
			this.TBDB.Text = "gas";
			// 
			// TBLogin
			// 
			this.TBLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBLogin.ForeColor = System.Drawing.Color.Gray;
			this.TBLogin.Location = new System.Drawing.Point(116, 47);
			this.TBLogin.Margin = new System.Windows.Forms.Padding(5);
			this.TBLogin.Name = "TBLogin";
			this.TBLogin.Size = new System.Drawing.Size(224, 26);
			this.TBLogin.TabIndex = 6;
			this.TBLogin.Text = "gas";
			// 
			// TBPassw
			// 
			this.TBPassw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBPassw.ForeColor = System.Drawing.Color.Gray;
			this.TBPassw.Location = new System.Drawing.Point(116, 79);
			this.TBPassw.Margin = new System.Windows.Forms.Padding(5);
			this.TBPassw.Name = "TBPassw";
			this.TBPassw.PasswordChar = '╥';
			this.TBPassw.Size = new System.Drawing.Size(224, 26);
			this.TBPassw.TabIndex = 7;
			this.TBPassw.Text = "gas";
			// 
			// TBServer
			// 
			this.TBServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBServer.Location = new System.Drawing.Point(116, 111);
			this.TBServer.Margin = new System.Windows.Forms.Padding(5);
			this.TBServer.Name = "TBServer";
			this.TBServer.Size = new System.Drawing.Size(224, 26);
			this.TBServer.TabIndex = 8;
			this.TBServer.Text = "localhost";
			// 
			// TBPatch
			// 
			this.TBPatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBPatch.Location = new System.Drawing.Point(124, 16);
			this.TBPatch.Margin = new System.Windows.Forms.Padding(5);
			this.TBPatch.Name = "TBPatch";
			this.TBPatch.ReadOnly = true;
			this.TBPatch.Size = new System.Drawing.Size(176, 26);
			this.TBPatch.TabIndex = 9;
			this.TBPatch.Text = "d:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(8, 60);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 18);
			this.label6.TabIndex = 4;
			this.label6.Text = "Файл sql / zip";
			// 
			// TBFileSQL
			// 
			this.TBFileSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TBFileSQL.Location = new System.Drawing.Point(124, 54);
			this.TBFileSQL.Margin = new System.Windows.Forms.Padding(5);
			this.TBFileSQL.Name = "TBFileSQL";
			this.TBFileSQL.Size = new System.Drawing.Size(220, 26);
			this.TBFileSQL.TabIndex = 9;
			this.TBFileSQL.Text = "Osipovichi";
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// ChBDelSQL
			// 
			this.ChBDelSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ChBDelSQL.AutoSize = true;
			this.ChBDelSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChBDelSQL.Location = new System.Drawing.Point(188, 90);
			this.ChBDelSQL.Margin = new System.Windows.Forms.Padding(5);
			this.ChBDelSQL.Name = "ChBDelSQL";
			this.ChBDelSQL.Size = new System.Drawing.Size(153, 21);
			this.ChBDelSQL.TabIndex = 12;
			this.ChBDelSQL.Text = "Удалить файл SQL";
			this.ChBDelSQL.UseVisualStyleBackColor = true;
			// 
			// LMess
			// 
			this.LMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LMess.AutoEllipsis = true;
			this.LMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LMess.ForeColor = System.Drawing.Color.DarkGreen;
			this.LMess.Location = new System.Drawing.Point(16, 182);
			this.LMess.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.LMess.Name = "LMess";
			this.LMess.Size = new System.Drawing.Size(336, 36);
			this.LMess.TabIndex = 13;
			this.LMess.Text = "***";
			this.LMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PSetups
			// 
			this.PSetups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PSetups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.PSetups.Controls.Add(this.TBServer);
			this.PSetups.Controls.Add(this.TBPassw);
			this.PSetups.Controls.Add(this.TBLogin);
			this.PSetups.Controls.Add(this.TBDB);
			this.PSetups.Controls.Add(this.label4);
			this.PSetups.Controls.Add(this.label3);
			this.PSetups.Controls.Add(this.label2);
			this.PSetups.Controls.Add(this.label1);
			this.PSetups.Location = new System.Drawing.Point(4, 4);
			this.PSetups.Name = "PSetups";
			this.PSetups.Size = new System.Drawing.Size(368, 15);
			this.PSetups.TabIndex = 15;
			this.PSetups.MouseEnter += new System.EventHandler(this.PSetups_MouseEnter);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.ChToMem);
			this.panel1.Controls.Add(this.BOpenFolder);
			this.panel1.Controls.Add(this.LMess);
			this.panel1.Controls.Add(this.ChBDelSQL);
			this.panel1.Controls.Add(this.BReserved);
			this.panel1.Controls.Add(this.TBFileSQL);
			this.panel1.Controls.Add(this.TBPatch);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Location = new System.Drawing.Point(4, 28);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(368, 228);
			this.panel1.TabIndex = 16;
			this.panel1.MouseEnter += new System.EventHandler(this.Panel1_MouseEnter);
			// 
			// BOpenFolder
			// 
			this.BOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BOpenFolder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BOpenFolder.Image = global::ReserveDB.Properties.Resources.Desktop_p6;
			this.BOpenFolder.Location = new System.Drawing.Point(312, 13);
			this.BOpenFolder.Name = "BOpenFolder";
			this.BOpenFolder.Size = new System.Drawing.Size(32, 32);
			this.BOpenFolder.TabIndex = 14;
			this.BOpenFolder.UseVisualStyleBackColor = true;
			this.BOpenFolder.Click += new System.EventHandler(this.BOpenFolder_Click);
			// 
			// BReserved
			// 
			this.BReserved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BReserved.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BReserved.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BReserved.Image = global::ReserveDB.Properties.Resources.DB_ok_p3;
			this.BReserved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BReserved.Location = new System.Drawing.Point(120, 134);
			this.BReserved.Margin = new System.Windows.Forms.Padding(5);
			this.BReserved.Name = "BReserved";
			this.BReserved.Size = new System.Drawing.Size(224, 43);
			this.BReserved.TabIndex = 0;
			this.BReserved.Text = "Резервировать";
			this.BReserved.UseVisualStyleBackColor = true;
			this.BReserved.Click += new System.EventHandler(this.BReserved_Click);
			// 
			// BClose
			// 
			this.BClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BClose.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BClose.Image = global::ReserveDB.Properties.Resources.Exit;
			this.BClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.BClose.Location = new System.Drawing.Point(0, 262);
			this.BClose.Margin = new System.Windows.Forms.Padding(5);
			this.BClose.Name = "BClose";
			this.BClose.Size = new System.Drawing.Size(375, 43);
			this.BClose.TabIndex = 10;
			this.BClose.Text = "Закрыть";
			this.BClose.UseVisualStyleBackColor = true;
			this.BClose.Click += new System.EventHandler(this.Button1_Click);
			// 
			// ChToMem
			// 
			this.ChToMem.AutoSize = true;
			this.ChToMem.Checked = true;
			this.ChToMem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ChToMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ChToMem.Location = new System.Drawing.Point(11, 90);
			this.ChToMem.Name = "ChToMem";
			this.ChToMem.Size = new System.Drawing.Size(112, 21);
			this.ChToMem.TabIndex = 15;
			this.ChToMem.Text = "SQL -  в ОЗУ";
			this.toolTip1.SetToolTip(this.ChToMem, "Создавать фай SQl  в ОЗУ (не на диске)");
			this.ChToMem.UseVisualStyleBackColor = true;
			this.ChToMem.CheckedChanged += new System.EventHandler(this.ChToMem_CheckedChanged);
			// 
			// FDumpDB_SQL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 305);
			this.Controls.Add(this.PSetups);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BClose);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MinimumSize = new System.Drawing.Size(16, 344);
			this.Name = "FDumpDB_SQL";
			this.Text = "БД - в sql-файл";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.SizeChanged += new System.EventHandler(this.FDumpDB_SQL_SizeChanged);
			this.MouseEnter += new System.EventHandler(this.Panel1_MouseEnter);
			this.PSetups.ResumeLayout(false);
			this.PSetups.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TBDB;
		private System.Windows.Forms.TextBox TBLogin;
		private System.Windows.Forms.TextBox TBPassw;
		private System.Windows.Forms.TextBox TBServer;
		private System.Windows.Forms.TextBox TBPatch;
		private System.Windows.Forms.Button BReserved;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TBFileSQL;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button BClose;
		private System.Windows.Forms.CheckBox ChBDelSQL;
		private System.Windows.Forms.Label LMess;
		private System.Windows.Forms.Button BOpenFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Panel PSetups;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox ChToMem;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}

