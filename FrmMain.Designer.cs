namespace CCSoundTrans
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.Conmain = new System.Data.Odbc.OdbcConnection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.pbYedek = new System.Windows.Forms.ProgressBar();
            this.btnRecShow = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBackBit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtBackBas = new System.Windows.Forms.DateTimePicker();
            this.grpDurum = new System.Windows.Forms.GroupBox();
            this.lstState = new System.Windows.Forms.ListBox();
            this.grpFiltre = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtKonSure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTarih2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih1 = new System.Windows.Forms.DateTimePicker();
            this.lblServer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.grdSound = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plFile = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            this.grpBackup.SuspendLayout();
            this.grpDurum.SuspendLayout();
            this.grpFiltre.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSound)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plFile)).BeginInit();
            this.SuspendLayout();
            // 
            // Conmain
            // 
            this.Conmain.ConnectionString = "Dsn=callserver;uid=root;pwd=Aa123456";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpBackup);
            this.panel1.Controls.Add(this.grpDurum);
            this.panel1.Controls.Add(this.grpFiltre);
            this.panel1.Controls.Add(this.lblServer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 170);
            this.panel1.TabIndex = 3;
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnlist);
            this.grpBackup.Controls.Add(this.pbYedek);
            this.grpBackup.Controls.Add(this.btnRecShow);
            this.grpBackup.Controls.Add(this.btnSaveAll);
            this.grpBackup.Controls.Add(this.chkDelete);
            this.grpBackup.Controls.Add(this.label6);
            this.grpBackup.Controls.Add(this.dtBackBit);
            this.grpBackup.Controls.Add(this.label7);
            this.grpBackup.Controls.Add(this.dtBackBas);
            this.grpBackup.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBackup.Location = new System.Drawing.Point(341, 13);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(249, 157);
            this.grpBackup.TabIndex = 11;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Yedekle";
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(9, 71);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(44, 23);
            this.btnlist.TabIndex = 19;
            this.btnlist.Text = "ListAll";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // pbYedek
            // 
            this.pbYedek.Location = new System.Drawing.Point(9, 130);
            this.pbYedek.Name = "pbYedek";
            this.pbYedek.Size = new System.Drawing.Size(226, 23);
            this.pbYedek.TabIndex = 17;
            // 
            // btnRecShow
            // 
            this.btnRecShow.Location = new System.Drawing.Point(113, 104);
            this.btnRecShow.Name = "btnRecShow";
            this.btnRecShow.Size = new System.Drawing.Size(56, 23);
            this.btnRecShow.TabIndex = 16;
            this.btnRecShow.Text = "Göster";
            this.btnRecShow.UseVisualStyleBackColor = true;
            this.btnRecShow.Click += new System.EventHandler(this.btnRecShow_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(175, 104);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(60, 23);
            this.btnSaveAll.TabIndex = 15;
            this.btnSaveAll.Text = "Yedekle";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Location = new System.Drawing.Point(99, 82);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(110, 17);
            this.chkDelete.TabIndex = 14;
            this.chkDelete.Text = "Yedeklenenleri Sil";
            this.chkDelete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Bitiþ Tarihi";
            // 
            // dtBackBit
            // 
            this.dtBackBit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBackBit.Location = new System.Drawing.Point(99, 47);
            this.dtBackBit.Name = "dtBackBit";
            this.dtBackBit.Size = new System.Drawing.Size(136, 20);
            this.dtBackBit.TabIndex = 12;
            this.dtBackBit.Value = new System.DateTime(2010, 11, 23, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Baþlangýç Tarihi";
            // 
            // dtBackBas
            // 
            this.dtBackBas.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBackBas.Location = new System.Drawing.Point(99, 18);
            this.dtBackBas.Name = "dtBackBas";
            this.dtBackBas.Size = new System.Drawing.Size(136, 20);
            this.dtBackBas.TabIndex = 10;
            this.dtBackBas.Value = new System.DateTime(2010, 11, 23, 0, 0, 0, 0);
            // 
            // grpDurum
            // 
            this.grpDurum.Controls.Add(this.lstState);
            this.grpDurum.Location = new System.Drawing.Point(596, 13);
            this.grpDurum.Name = "grpDurum";
            this.grpDurum.Size = new System.Drawing.Size(376, 157);
            this.grpDurum.TabIndex = 10;
            this.grpDurum.TabStop = false;
            this.grpDurum.Text = "Durum";
            // 
            // lstState
            // 
            this.lstState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstState.FormattingEnabled = true;
            this.lstState.Location = new System.Drawing.Point(3, 16);
            this.lstState.Name = "lstState";
            this.lstState.Size = new System.Drawing.Size(370, 138);
            this.lstState.TabIndex = 0;
            // 
            // grpFiltre
            // 
            this.grpFiltre.Controls.Add(this.btnSave);
            this.grpFiltre.Controls.Add(this.txtKonSure);
            this.grpFiltre.Controls.Add(this.label5);
            this.grpFiltre.Controls.Add(this.cmdState);
            this.grpFiltre.Controls.Add(this.label4);
            this.grpFiltre.Controls.Add(this.label3);
            this.grpFiltre.Controls.Add(this.txtSearch);
            this.grpFiltre.Controls.Add(this.btnListen);
            this.grpFiltre.Controls.Add(this.btnSearch);
            this.grpFiltre.Controls.Add(this.label2);
            this.grpFiltre.Controls.Add(this.dtTarih2);
            this.grpFiltre.Controls.Add(this.label1);
            this.grpFiltre.Controls.Add(this.dtTarih1);
            this.grpFiltre.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpFiltre.Location = new System.Drawing.Point(0, 13);
            this.grpFiltre.Name = "grpFiltre";
            this.grpFiltre.Size = new System.Drawing.Size(341, 157);
            this.grpFiltre.TabIndex = 9;
            this.grpFiltre.TabStop = false;
            this.grpFiltre.Text = "Filtrele";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtKonSure
            // 
            this.txtKonSure.Location = new System.Drawing.Point(99, 130);
            this.txtKonSure.Name = "txtKonSure";
            this.txtKonSure.Size = new System.Drawing.Size(48, 20);
            this.txtKonSure.TabIndex = 17;
            this.txtKonSure.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Konuþma Süresi";
            // 
            // cmdState
            // 
            this.cmdState.FormattingEnabled = true;
            this.cmdState.Items.AddRange(new object[] {
            "ALL",
            "ANSWERED",
            "NO ANSWER",
            "BUSY",
            "FAILED",
            "SAVED",
            "SAVED DELETED"});
            this.cmdState.Location = new System.Drawing.Point(99, 100);
            this.cmdState.Name = "cmdState";
            this.cmdState.Size = new System.Drawing.Size(136, 21);
            this.cmdState.TabIndex = 15;
            this.cmdState.Text = "ANSWERED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Arayan/Aranan";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(99, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(136, 20);
            this.txtSearch.TabIndex = 12;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(256, 42);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(75, 23);
            this.btnListen.TabIndex = 11;
            this.btnListen.Text = "Dinle";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(256, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bitiþ Tarihi";
            // 
            // dtTarih2
            // 
            this.dtTarih2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih2.Location = new System.Drawing.Point(99, 46);
            this.dtTarih2.Name = "dtTarih2";
            this.dtTarih2.Size = new System.Drawing.Size(136, 20);
            this.dtTarih2.TabIndex = 8;
            this.dtTarih2.Value = new System.DateTime(2010, 11, 23, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Baþlangýç Tarihi";
            // 
            // dtTarih1
            // 
            this.dtTarih1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih1.Location = new System.Drawing.Point(99, 17);
            this.dtTarih1.Name = "dtTarih1";
            this.dtTarih1.Size = new System.Drawing.Size(136, 20);
            this.dtTarih1.TabIndex = 6;
            this.dtTarih1.Value = new System.DateTime(2010, 11, 23, 0, 0, 0, 0);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServer.Location = new System.Drawing.Point(0, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(35, 13);
            this.lblServer.TabIndex = 8;
            this.lblServer.Text = "label3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 283);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 221);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.grdSound);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(930, 221);
            this.panel6.TabIndex = 7;
            // 
            // grdSound
            // 
            this.grdSound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdSound.Location = new System.Drawing.Point(0, 0);
            this.grdSound.Name = "grdSound";
            this.grdSound.Size = new System.Drawing.Size(930, 221);
            this.grdSound.TabIndex = 4;
            this.grdSound.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSound_CellDoubleClick);
            this.grdSound.SelectionChanged += new System.EventHandler(this.grdSound_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plFile);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 62);
            this.panel3.TabIndex = 4;
            // 
            // plFile
            // 
            this.plFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plFile.Enabled = true;
            this.plFile.Location = new System.Drawing.Point(0, 0);
            this.plFile.Name = "plFile";
            this.plFile.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("plFile.OcxState")));
            this.plFile.Size = new System.Drawing.Size(930, 62);
            this.plFile.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Ses Kayýt Dinleyicisi";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.grpDurum.ResumeLayout(false);
            this.grpFiltre.ResumeLayout(false);
            this.grpFiltre.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSound)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Odbc.OdbcConnection Conmain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.GroupBox grpFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTarih2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih1;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmdState;
        private System.Windows.Forms.GroupBox grpDurum;
        private System.Windows.Forms.ListBox lstState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKonSure;
        private System.Windows.Forms.Panel panel3;
        private AxWMPLib.AxWindowsMediaPlayer plFile;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdSound;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBackBit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtBackBas;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnRecShow;
        private System.Windows.Forms.ProgressBar pbYedek;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Panel panel6;
    }
}

