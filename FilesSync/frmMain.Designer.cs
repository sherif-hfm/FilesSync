namespace FilesSync
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imgLoading = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSetting = new System.Windows.Forms.TabPage();
            this.btnFileScan = new System.Windows.Forms.Button();
            this.btnStartWatching = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.prop = new System.Windows.Forms.PropertyGrid();
            this.tabChangesLog = new System.Windows.Forms.TabPage();
            this.btnChangesRefresh = new System.Windows.Forms.Button();
            this.btnDeleteChecked = new System.Windows.Forms.Button();
            this.chkChangesAutoRefresh = new System.Windows.Forms.CheckBox();
            this.chkAutoSendToSync = new System.Windows.Forms.CheckBox();
            this.chkServers = new System.Windows.Forms.CheckedListBox();
            this.btnAddToSync = new System.Windows.Forms.Button();
            this.grdChanges = new System.Windows.Forms.DataGridView();
            this.ChangesChk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WatcherPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedToSync = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSyncLog = new System.Windows.Forms.TabPage();
            this.btnSyncRefresh = new System.Windows.Forms.Button();
            this.chkSyncAutoRefresh = new System.Windows.Forms.CheckBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.grdSyncLog = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topMostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerChangeLog = new System.Windows.Forms.Timer(this.components);
            this.timerSyncLog = new System.Windows.Forms.Timer(this.components);
            this.timerBusy = new System.Windows.Forms.Timer(this.components);
            this.btnFileIndexing = new System.Windows.Forms.Button();
            this.btnDelAllChanges = new System.Windows.Forms.Button();
            this.chkSync = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DestinationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyncAddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SourcePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationRoot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DestinationPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyncTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SyncStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Syncid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSyncDelAll = new System.Windows.Forms.Button();
            this.btnSyncDelCheck = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSetting.SuspendLayout();
            this.tabChangesLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChanges)).BeginInit();
            this.tabSyncLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSyncLog)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imgLoading});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1085, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imgLoading
            // 
            this.imgLoading.Image = global::FilesSync.Properties.Resources.Loading;
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(16, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSetting);
            this.tabControl1.Controls.Add(this.tabChangesLog);
            this.tabControl1.Controls.Add(this.tabSyncLog);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 325);
            this.tabControl1.TabIndex = 2;
            // 
            // tabSetting
            // 
            this.tabSetting.Controls.Add(this.btnFileIndexing);
            this.tabSetting.Controls.Add(this.btnFileScan);
            this.tabSetting.Controls.Add(this.btnStartWatching);
            this.tabSetting.Controls.Add(this.btnSave);
            this.tabSetting.Controls.Add(this.prop);
            this.tabSetting.Location = new System.Drawing.Point(4, 28);
            this.tabSetting.Name = "tabSetting";
            this.tabSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetting.Size = new System.Drawing.Size(1077, 293);
            this.tabSetting.TabIndex = 0;
            this.tabSetting.Text = "Setting";
            this.tabSetting.UseVisualStyleBackColor = true;
            // 
            // btnFileScan
            // 
            this.btnFileScan.Location = new System.Drawing.Point(910, 166);
            this.btnFileScan.Name = "btnFileScan";
            this.btnFileScan.Size = new System.Drawing.Size(159, 35);
            this.btnFileScan.TabIndex = 3;
            this.btnFileScan.Text = "File Scan";
            this.btnFileScan.UseVisualStyleBackColor = true;
            this.btnFileScan.Click += new System.EventHandler(this.btnFileScan_Click);
            // 
            // btnStartWatching
            // 
            this.btnStartWatching.ForeColor = System.Drawing.Color.Green;
            this.btnStartWatching.Location = new System.Drawing.Point(910, 252);
            this.btnStartWatching.Name = "btnStartWatching";
            this.btnStartWatching.Size = new System.Drawing.Size(159, 35);
            this.btnStartWatching.TabIndex = 2;
            this.btnStartWatching.Text = "Start Watching";
            this.btnStartWatching.UseVisualStyleBackColor = true;
            this.btnStartWatching.Click += new System.EventHandler(this.btnStartWatching_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(910, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(159, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // prop
            // 
            this.prop.Location = new System.Drawing.Point(8, 6);
            this.prop.Name = "prop";
            this.prop.Size = new System.Drawing.Size(886, 281);
            this.prop.TabIndex = 0;
            // 
            // tabChangesLog
            // 
            this.tabChangesLog.Controls.Add(this.btnDelAllChanges);
            this.tabChangesLog.Controls.Add(this.btnChangesRefresh);
            this.tabChangesLog.Controls.Add(this.btnDeleteChecked);
            this.tabChangesLog.Controls.Add(this.chkChangesAutoRefresh);
            this.tabChangesLog.Controls.Add(this.chkAutoSendToSync);
            this.tabChangesLog.Controls.Add(this.chkServers);
            this.tabChangesLog.Controls.Add(this.btnAddToSync);
            this.tabChangesLog.Controls.Add(this.grdChanges);
            this.tabChangesLog.Location = new System.Drawing.Point(4, 28);
            this.tabChangesLog.Name = "tabChangesLog";
            this.tabChangesLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangesLog.Size = new System.Drawing.Size(1077, 293);
            this.tabChangesLog.TabIndex = 1;
            this.tabChangesLog.Text = "Changes Log";
            this.tabChangesLog.UseVisualStyleBackColor = true;
            // 
            // btnChangesRefresh
            // 
            this.btnChangesRefresh.Location = new System.Drawing.Point(755, 198);
            this.btnChangesRefresh.Name = "btnChangesRefresh";
            this.btnChangesRefresh.Size = new System.Drawing.Size(137, 34);
            this.btnChangesRefresh.TabIndex = 8;
            this.btnChangesRefresh.Text = "Refresh";
            this.btnChangesRefresh.UseVisualStyleBackColor = true;
            this.btnChangesRefresh.Click += new System.EventHandler(this.btnChangesRefresh_Click);
            // 
            // btnDeleteChecked
            // 
            this.btnDeleteChecked.Location = new System.Drawing.Point(6, 198);
            this.btnDeleteChecked.Name = "btnDeleteChecked";
            this.btnDeleteChecked.Size = new System.Drawing.Size(137, 34);
            this.btnDeleteChecked.TabIndex = 7;
            this.btnDeleteChecked.Text = "Delete Checked";
            this.btnDeleteChecked.UseVisualStyleBackColor = true;
            this.btnDeleteChecked.Click += new System.EventHandler(this.btnDeleteChecked_Click);
            // 
            // chkChangesAutoRefresh
            // 
            this.chkChangesAutoRefresh.AutoSize = true;
            this.chkChangesAutoRefresh.Location = new System.Drawing.Point(918, 227);
            this.chkChangesAutoRefresh.Name = "chkChangesAutoRefresh";
            this.chkChangesAutoRefresh.Size = new System.Drawing.Size(108, 23);
            this.chkChangesAutoRefresh.TabIndex = 6;
            this.chkChangesAutoRefresh.Text = "Auto Refresh";
            this.chkChangesAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // chkAutoSendToSync
            // 
            this.chkAutoSendToSync.AutoSize = true;
            this.chkAutoSendToSync.Location = new System.Drawing.Point(918, 198);
            this.chkAutoSendToSync.Name = "chkAutoSendToSync";
            this.chkAutoSendToSync.Size = new System.Drawing.Size(147, 23);
            this.chkAutoSendToSync.TabIndex = 3;
            this.chkAutoSendToSync.Text = "Auto Send To Sync";
            this.chkAutoSendToSync.UseVisualStyleBackColor = true;
            // 
            // chkServers
            // 
            this.chkServers.FormattingEnabled = true;
            this.chkServers.Location = new System.Drawing.Point(458, 198);
            this.chkServers.Name = "chkServers";
            this.chkServers.Size = new System.Drawing.Size(195, 88);
            this.chkServers.TabIndex = 2;
            // 
            // btnAddToSync
            // 
            this.btnAddToSync.Location = new System.Drawing.Point(315, 198);
            this.btnAddToSync.Name = "btnAddToSync";
            this.btnAddToSync.Size = new System.Drawing.Size(137, 34);
            this.btnAddToSync.TabIndex = 1;
            this.btnAddToSync.Text = "AddToSync";
            this.btnAddToSync.UseVisualStyleBackColor = true;
            this.btnAddToSync.Click += new System.EventHandler(this.btnAddToSync_Click);
            // 
            // grdChanges
            // 
            this.grdChanges.AllowUserToAddRows = false;
            this.grdChanges.AllowUserToDeleteRows = false;
            this.grdChanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdChanges.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChangesChk,
            this.AddTime,
            this.FilePath,
            this.WatcherPath,
            this.Action,
            this.AddedToSync,
            this.Id});
            this.grdChanges.Location = new System.Drawing.Point(6, 6);
            this.grdChanges.Name = "grdChanges";
            this.grdChanges.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdChanges.Size = new System.Drawing.Size(1059, 186);
            this.grdChanges.TabIndex = 0;
            // 
            // ChangesChk
            // 
            this.ChangesChk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChangesChk.HeaderText = "*";
            this.ChangesChk.Name = "ChangesChk";
            this.ChangesChk.Width = 23;
            // 
            // AddTime
            // 
            this.AddTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddTime.DataPropertyName = "AddTime";
            this.AddTime.HeaderText = "AddTime";
            this.AddTime.Name = "AddTime";
            this.AddTime.ReadOnly = true;
            this.AddTime.Width = 90;
            // 
            // FilePath
            // 
            this.FilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Width = 83;
            // 
            // WatcherPath
            // 
            this.WatcherPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.WatcherPath.DataPropertyName = "WatcherPath";
            this.WatcherPath.HeaderText = "WatcherPath";
            this.WatcherPath.Name = "WatcherPath";
            this.WatcherPath.ReadOnly = true;
            this.WatcherPath.Width = 112;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Action.DataPropertyName = "Action";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 74;
            // 
            // AddedToSync
            // 
            this.AddedToSync.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddedToSync.DataPropertyName = "AddedToSync";
            this.AddedToSync.HeaderText = "AddedToSync";
            this.AddedToSync.Name = "AddedToSync";
            this.AddedToSync.ReadOnly = true;
            this.AddedToSync.Width = 122;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // tabSyncLog
            // 
            this.tabSyncLog.Controls.Add(this.btnSyncDelAll);
            this.tabSyncLog.Controls.Add(this.btnSyncDelCheck);
            this.tabSyncLog.Controls.Add(this.btnSyncRefresh);
            this.tabSyncLog.Controls.Add(this.chkSyncAutoRefresh);
            this.tabSyncLog.Controls.Add(this.chkAutoSend);
            this.tabSyncLog.Controls.Add(this.btnSync);
            this.tabSyncLog.Controls.Add(this.grdSyncLog);
            this.tabSyncLog.Location = new System.Drawing.Point(4, 28);
            this.tabSyncLog.Name = "tabSyncLog";
            this.tabSyncLog.Size = new System.Drawing.Size(1077, 293);
            this.tabSyncLog.TabIndex = 2;
            this.tabSyncLog.Text = "Sync Log";
            this.tabSyncLog.UseVisualStyleBackColor = true;
            // 
            // btnSyncRefresh
            // 
            this.btnSyncRefresh.Location = new System.Drawing.Point(655, 256);
            this.btnSyncRefresh.Name = "btnSyncRefresh";
            this.btnSyncRefresh.Size = new System.Drawing.Size(137, 34);
            this.btnSyncRefresh.TabIndex = 9;
            this.btnSyncRefresh.Text = "Refresh";
            this.btnSyncRefresh.UseVisualStyleBackColor = true;
            this.btnSyncRefresh.Click += new System.EventHandler(this.btnSyncRefresh_Click);
            // 
            // chkSyncAutoRefresh
            // 
            this.chkSyncAutoRefresh.AutoSize = true;
            this.chkSyncAutoRefresh.Location = new System.Drawing.Point(798, 256);
            this.chkSyncAutoRefresh.Name = "chkSyncAutoRefresh";
            this.chkSyncAutoRefresh.Size = new System.Drawing.Size(108, 23);
            this.chkSyncAutoRefresh.TabIndex = 5;
            this.chkSyncAutoRefresh.Text = "Auto Refresh";
            this.chkSyncAutoRefresh.UseVisualStyleBackColor = true;
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(974, 256);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(92, 23);
            this.chkAutoSend.TabIndex = 4;
            this.chkAutoSend.Text = "Auto Sync";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(528, 256);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(111, 34);
            this.btnSync.TabIndex = 2;
            this.btnSync.Text = "Sync";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // grdSyncLog
            // 
            this.grdSyncLog.AllowUserToAddRows = false;
            this.grdSyncLog.AllowUserToDeleteRows = false;
            this.grdSyncLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdSyncLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSyncLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSync,
            this.DestinationName,
            this.SyncAddTime,
            this.SourcePath,
            this.DestinationRoot,
            this.DestinationPath,
            this.SyncTime,
            this.SyncStatus,
            this.Message,
            this.Syncid});
            this.grdSyncLog.Location = new System.Drawing.Point(8, 14);
            this.grdSyncLog.Name = "grdSyncLog";
            this.grdSyncLog.Size = new System.Drawing.Size(1059, 236);
            this.grdSyncLog.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.topMostToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // topMostToolStripMenuItem
            // 
            this.topMostToolStripMenuItem.CheckOnClick = true;
            this.topMostToolStripMenuItem.Name = "topMostToolStripMenuItem";
            this.topMostToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.topMostToolStripMenuItem.Text = "Top Most";
            this.topMostToolStripMenuItem.Click += new System.EventHandler(this.topMostToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // timerChangeLog
            // 
            this.timerChangeLog.Interval = 1000;
            this.timerChangeLog.Tick += new System.EventHandler(this.timerChangeLog_Tick);
            // 
            // timerSyncLog
            // 
            this.timerSyncLog.Interval = 1000;
            this.timerSyncLog.Tick += new System.EventHandler(this.timerSyncLog_Tick);
            // 
            // timerBusy
            // 
            this.timerBusy.Enabled = true;
            this.timerBusy.Interval = 1000;
            this.timerBusy.Tick += new System.EventHandler(this.timerBusy_Tick);
            // 
            // btnFileIndexing
            // 
            this.btnFileIndexing.Location = new System.Drawing.Point(910, 125);
            this.btnFileIndexing.Name = "btnFileIndexing";
            this.btnFileIndexing.Size = new System.Drawing.Size(159, 35);
            this.btnFileIndexing.TabIndex = 4;
            this.btnFileIndexing.Text = "File Indexing";
            this.btnFileIndexing.UseVisualStyleBackColor = true;
            this.btnFileIndexing.Click += new System.EventHandler(this.btnFileIndexing_Click);
            // 
            // btnDelAllChanges
            // 
            this.btnDelAllChanges.Location = new System.Drawing.Point(6, 238);
            this.btnDelAllChanges.Name = "btnDelAllChanges";
            this.btnDelAllChanges.Size = new System.Drawing.Size(137, 34);
            this.btnDelAllChanges.TabIndex = 9;
            this.btnDelAllChanges.Text = "Delete All";
            this.btnDelAllChanges.UseVisualStyleBackColor = true;
            this.btnDelAllChanges.Click += new System.EventHandler(this.btnDelAllChanges_Click);
            // 
            // chkSync
            // 
            this.chkSync.HeaderText = "*";
            this.chkSync.Name = "chkSync";
            this.chkSync.Width = 23;
            // 
            // DestinationName
            // 
            this.DestinationName.DataPropertyName = "DestinationName";
            this.DestinationName.HeaderText = "DestinationName";
            this.DestinationName.Name = "DestinationName";
            this.DestinationName.ReadOnly = true;
            this.DestinationName.Width = 138;
            // 
            // SyncAddTime
            // 
            this.SyncAddTime.DataPropertyName = "AddTime";
            this.SyncAddTime.HeaderText = "SyncAddTime";
            this.SyncAddTime.Name = "SyncAddTime";
            this.SyncAddTime.ReadOnly = true;
            this.SyncAddTime.Width = 120;
            // 
            // SourcePath
            // 
            this.SourcePath.DataPropertyName = "SourcePath";
            this.SourcePath.HeaderText = "SourcePath";
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.ReadOnly = true;
            this.SourcePath.Width = 104;
            // 
            // DestinationRoot
            // 
            this.DestinationRoot.DataPropertyName = "DestinationRoot";
            this.DestinationRoot.HeaderText = "DestinationRoot";
            this.DestinationRoot.Name = "DestinationRoot";
            this.DestinationRoot.ReadOnly = true;
            this.DestinationRoot.Width = 131;
            // 
            // DestinationPath
            // 
            this.DestinationPath.DataPropertyName = "DestinationPath";
            this.DestinationPath.HeaderText = "DestinationPath";
            this.DestinationPath.Name = "DestinationPath";
            this.DestinationPath.ReadOnly = true;
            this.DestinationPath.Width = 128;
            // 
            // SyncTime
            // 
            this.SyncTime.DataPropertyName = "SyncTime";
            this.SyncTime.HeaderText = "SyncTime";
            this.SyncTime.Name = "SyncTime";
            this.SyncTime.ReadOnly = true;
            this.SyncTime.Width = 93;
            // 
            // SyncStatus
            // 
            this.SyncStatus.DataPropertyName = "SyncStatus";
            this.SyncStatus.HeaderText = "SyncStatus";
            this.SyncStatus.Name = "SyncStatus";
            this.SyncStatus.ReadOnly = true;
            this.SyncStatus.Width = 101;
            // 
            // Message
            // 
            this.Message.DataPropertyName = "Message";
            this.Message.HeaderText = "Message";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 88;
            // 
            // Syncid
            // 
            this.Syncid.DataPropertyName = "Id";
            this.Syncid.HeaderText = "Syncid";
            this.Syncid.Name = "Syncid";
            this.Syncid.ReadOnly = true;
            this.Syncid.Visible = false;
            this.Syncid.Width = 75;
            // 
            // btnSyncDelAll
            // 
            this.btnSyncDelAll.Location = new System.Drawing.Point(162, 256);
            this.btnSyncDelAll.Name = "btnSyncDelAll";
            this.btnSyncDelAll.Size = new System.Drawing.Size(137, 34);
            this.btnSyncDelAll.TabIndex = 11;
            this.btnSyncDelAll.Text = "Delete All";
            this.btnSyncDelAll.UseVisualStyleBackColor = true;
            this.btnSyncDelAll.Click += new System.EventHandler(this.btnSyncDelAll_Click);
            // 
            // btnSyncDelCheck
            // 
            this.btnSyncDelCheck.Location = new System.Drawing.Point(8, 256);
            this.btnSyncDelCheck.Name = "btnSyncDelCheck";
            this.btnSyncDelCheck.Size = new System.Drawing.Size(137, 34);
            this.btnSyncDelCheck.TabIndex = 10;
            this.btnSyncDelCheck.Text = "Delete Checked";
            this.btnSyncDelCheck.UseVisualStyleBackColor = true;
            this.btnSyncDelCheck.Click += new System.EventHandler(this.btnSyncDelCheck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 371);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files Sync";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSetting.ResumeLayout(false);
            this.tabChangesLog.ResumeLayout(false);
            this.tabChangesLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdChanges)).EndInit();
            this.tabSyncLog.ResumeLayout(false);
            this.tabSyncLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSyncLog)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSetting;
        private System.Windows.Forms.TabPage tabChangesLog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage tabSyncLog;
        private System.Windows.Forms.DataGridView grdChanges;
        private System.Windows.Forms.Timer timerChangeLog;
        private System.Windows.Forms.Button btnAddToSync;
        private System.Windows.Forms.DataGridView grdSyncLog;
        private System.Windows.Forms.Timer timerSyncLog;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.PropertyGrid prop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStartWatching;
        private System.Windows.Forms.CheckedListBox chkServers;
        private System.Windows.Forms.CheckBox chkAutoSendToSync;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.Button btnFileScan;
        private System.Windows.Forms.CheckBox chkSyncAutoRefresh;
        private System.Windows.Forms.CheckBox chkChangesAutoRefresh;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChangesChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn WatcherPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedToSync;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button btnDeleteChecked;
        private System.Windows.Forms.ToolStripMenuItem topMostToolStripMenuItem;
        private System.Windows.Forms.Button btnChangesRefresh;
        private System.Windows.Forms.Button btnSyncRefresh;
        private System.Windows.Forms.ToolStripStatusLabel imgLoading;
        private System.Windows.Forms.Timer timerBusy;
        private System.Windows.Forms.Button btnFileIndexing;
        private System.Windows.Forms.Button btnDelAllChanges;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSync;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyncAddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SourcePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationRoot;
        private System.Windows.Forms.DataGridViewTextBoxColumn DestinationPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyncTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SyncStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn Syncid;
        private System.Windows.Forms.Button btnSyncDelAll;
        private System.Windows.Forms.Button btnSyncDelCheck;
    }
}

