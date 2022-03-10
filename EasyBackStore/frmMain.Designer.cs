namespace EasyBackStore
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolsMain = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRestore = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelRestoreOptions = new System.Windows.Forms.Panel();
            this.chkCloseConnections = new System.Windows.Forms.CheckBox();
            this.chkRecovery = new System.Windows.Forms.CheckBox();
            this.txtDataFolder = new System.Windows.Forms.TextBox();
            this.chkReplace = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogFolder = new System.Windows.Forms.Button();
            this.chkRelocate = new System.Windows.Forms.CheckBox();
            this.btnDataFolder = new System.Windows.Forms.Button();
            this.txtLogFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofdBakFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdBakFile = new System.Windows.Forms.SaveFileDialog();
            this.fbdRelocateFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.toolsMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panelRestoreOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolsMain
            // 
            this.toolsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbOpen,
            this.toolStripSeparator2,
            this.tsbRestore});
            this.toolsMain.Location = new System.Drawing.Point(0, 0);
            this.toolsMain.Name = "toolsMain";
            this.toolsMain.Size = new System.Drawing.Size(684, 31);
            this.toolsMain.TabIndex = 2;
            this.toolsMain.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::EasyBackStore.Properties.Resources.filesaveas_32;
            this.tsbSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(59, 28);
            this.tsbSave.Text = "&Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbOpen
            // 
            this.tsbOpen.Image = global::EasyBackStore.Properties.Resources.Open;
            this.tsbOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(64, 28);
            this.tsbOpen.Text = "&Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbRestore
            // 
            this.tsbRestore.Enabled = false;
            this.tsbRestore.Image = global::EasyBackStore.Properties.Resources.Reload;
            this.tsbRestore.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbRestore.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestore.Name = "tsbRestore";
            this.tsbRestore.Size = new System.Drawing.Size(74, 28);
            this.tsbRestore.Text = "&Restore";
            this.tsbRestore.Click += new System.EventHandler(this.tsbRestore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cmbDatabases);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup options:";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(400, 75);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(201, 23);
            this.checkBox4.TabIndex = 5;
            this.checkBox4.Text = "Shrink log file before backup";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(565, 35);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 23);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Copy_Only";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(470, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 23);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Format";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(400, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Init";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmbDatabases
            // 
            this.cmbDatabases.FormattingEnabled = true;
            this.cmbDatabases.Location = new System.Drawing.Point(115, 74);
            this.cmbDatabases.Name = "cmbDatabases";
            this.cmbDatabases.Size = new System.Drawing.Size(220, 25);
            this.cmbDatabases.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Database:";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(115, 34);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(220, 25);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelRestoreOptions);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 314);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore options:";
            // 
            // panelRestoreOptions
            // 
            this.panelRestoreOptions.Controls.Add(this.chkCloseConnections);
            this.panelRestoreOptions.Controls.Add(this.chkRecovery);
            this.panelRestoreOptions.Controls.Add(this.txtDataFolder);
            this.panelRestoreOptions.Controls.Add(this.chkReplace);
            this.panelRestoreOptions.Controls.Add(this.label4);
            this.panelRestoreOptions.Controls.Add(this.btnLogFolder);
            this.panelRestoreOptions.Controls.Add(this.chkRelocate);
            this.panelRestoreOptions.Controls.Add(this.btnDataFolder);
            this.panelRestoreOptions.Controls.Add(this.txtLogFolder);
            this.panelRestoreOptions.Controls.Add(this.label5);
            this.panelRestoreOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRestoreOptions.Enabled = false;
            this.panelRestoreOptions.Location = new System.Drawing.Point(3, 65);
            this.panelRestoreOptions.Name = "panelRestoreOptions";
            this.panelRestoreOptions.Size = new System.Drawing.Size(678, 246);
            this.panelRestoreOptions.TabIndex = 0;
            // 
            // chkCloseConnections
            // 
            this.chkCloseConnections.AutoSize = true;
            this.chkCloseConnections.Checked = true;
            this.chkCloseConnections.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCloseConnections.Location = new System.Drawing.Point(15, 210);
            this.chkCloseConnections.Name = "chkCloseConnections";
            this.chkCloseConnections.Size = new System.Drawing.Size(336, 23);
            this.chkCloseConnections.TabIndex = 5;
            this.chkCloseConnections.Text = "Close existing connections to destination database";
            this.chkCloseConnections.UseVisualStyleBackColor = true;
            // 
            // chkRecovery
            // 
            this.chkRecovery.AutoSize = true;
            this.chkRecovery.Checked = true;
            this.chkRecovery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecovery.Location = new System.Drawing.Point(15, 170);
            this.chkRecovery.Name = "chkRecovery";
            this.chkRecovery.Size = new System.Drawing.Size(191, 23);
            this.chkRecovery.TabIndex = 4;
            this.chkRecovery.Text = "RESTORE WITH RECOVERY";
            this.chkRecovery.UseVisualStyleBackColor = true;
            // 
            // txtDataFolder
            // 
            this.txtDataFolder.Enabled = false;
            this.txtDataFolder.Location = new System.Drawing.Point(115, 42);
            this.txtDataFolder.Name = "txtDataFolder";
            this.txtDataFolder.Size = new System.Drawing.Size(435, 25);
            this.txtDataFolder.TabIndex = 1;
            // 
            // chkReplace
            // 
            this.chkReplace.AutoSize = true;
            this.chkReplace.Location = new System.Drawing.Point(15, 130);
            this.chkReplace.Name = "chkReplace";
            this.chkReplace.Size = new System.Drawing.Size(326, 23);
            this.chkReplace.TabIndex = 3;
            this.chkReplace.Text = "Overwrite the existing database (WITH REPLACE)";
            this.chkReplace.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data file folder:";
            // 
            // btnLogFolder
            // 
            this.btnLogFolder.Enabled = false;
            this.btnLogFolder.Location = new System.Drawing.Point(560, 77);
            this.btnLogFolder.Name = "btnLogFolder";
            this.btnLogFolder.Size = new System.Drawing.Size(40, 35);
            this.btnLogFolder.TabIndex = 7;
            this.btnLogFolder.TabStop = false;
            this.btnLogFolder.Text = "...";
            this.btnLogFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogFolder.UseVisualStyleBackColor = true;
            this.btnLogFolder.Click += new System.EventHandler(this.btnLogFolder_Click);
            // 
            // chkRelocate
            // 
            this.chkRelocate.AutoSize = true;
            this.chkRelocate.Enabled = false;
            this.chkRelocate.Location = new System.Drawing.Point(120, 10);
            this.chkRelocate.Name = "chkRelocate";
            this.chkRelocate.Size = new System.Drawing.Size(179, 23);
            this.chkRelocate.TabIndex = 0;
            this.chkRelocate.Text = "Relocate all files to folder";
            this.chkRelocate.UseVisualStyleBackColor = true;
            this.chkRelocate.CheckedChanged += new System.EventHandler(this.chkRelocate_CheckedChanged);
            // 
            // btnDataFolder
            // 
            this.btnDataFolder.Enabled = false;
            this.btnDataFolder.Location = new System.Drawing.Point(560, 37);
            this.btnDataFolder.Name = "btnDataFolder";
            this.btnDataFolder.Size = new System.Drawing.Size(40, 35);
            this.btnDataFolder.TabIndex = 6;
            this.btnDataFolder.TabStop = false;
            this.btnDataFolder.Text = "...";
            this.btnDataFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDataFolder.UseVisualStyleBackColor = true;
            this.btnDataFolder.Click += new System.EventHandler(this.btnDataFolder_Click);
            // 
            // txtLogFolder
            // 
            this.txtLogFolder.Enabled = false;
            this.txtLogFolder.Location = new System.Drawing.Point(115, 82);
            this.txtLogFolder.Name = "txtLogFolder";
            this.txtLogFolder.Size = new System.Drawing.Size(435, 25);
            this.txtLogFolder.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(15, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Log file folder:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 44);
            this.panel1.TabIndex = 13;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(90, 10);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(580, 30);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFileName.TextChanged += new System.EventHandler(this.lblFileName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Backup file:";
            // 
            // ofdBakFile
            // 
            this.ofdBakFile.FileName = "Backup Files";
            this.ofdBakFile.Filter = "bak file|*.bak";
            // 
            // sfdBakFile
            // 
            this.sfdBakFile.Filter = "Backup Files|*.bak";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolsMain);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Sql Server DB Backup/Restore";
            this.toolsMain.ResumeLayout(false);
            this.toolsMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panelRestoreOptions.ResumeLayout(false);
            this.panelRestoreOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolsMain;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ToolStripButton tsbSave;
        private TextBox txtServerName;
        private Label label1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ComboBox cmbDatabases;
        private Label label2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbOpen;
        private OpenFileDialog ofdBakFile;
        private SaveFileDialog sfdBakFile;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbRestore;
        private Label lblFileName;
        private Label label3;
        private Button btnLogFolder;
        private Button btnDataFolder;
        private Label label5;
        private TextBox txtLogFolder;
        private CheckBox chkRelocate;
        private Label label4;
        private TextBox txtDataFolder;
        private CheckBox chkRecovery;
        private FolderBrowserDialog fbdRelocateFolder;
        private CheckBox chkCloseConnections;
        private CheckBox chkReplace;
        private Panel panelRestoreOptions;
        private Panel panel1;
    }
}