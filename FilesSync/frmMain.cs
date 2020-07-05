using FilesSync.Helpers;
using FilesSync.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesSync
{
    public partial class frmMain : Form
    {
        bool ChangesBusy = false;
        bool SyncBusy = false;
        bool FileScanBusy = false;
        

        int FilemWatcherStatus = 0;
        List<FileSystemWatcher> FileSystemWatchers;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timerChangeLog.Enabled = true;
            timerSyncLog.Enabled = true;
            var setting = LogHelper.GetSetting();
            if (setting == null)
            {
                setting = new Setting();
                LogHelper.AddSetting(setting);
            }

            Setting.CurrentSetting = setting;
            prop.SelectedObject = Setting.CurrentSetting;
            FillServersChk();
            chkAutoSendToSync.Checked = Setting.CurrentSetting.AutoSendToSync;
            chkAutoSend.Checked = Setting.CurrentSetting.AutoSync;
            if (Setting.CurrentSetting.AutoStartFileWatching)
            {
                StartWatching();
            }
        }

        private void CreaetFileSystemWatchers()
        {
            var setting = Setting.CurrentSetting;
            if (FileSystemWatchers == null)
                FileSystemWatchers = new List<FileSystemWatcher>();
            if (setting.Paths != null)
            {
                foreach (var path in setting.Paths.FindAll(p => p.IsActive == true))
                {
                    var isExist = FileSystemWatchers.Find(w => w.Path == path.Path);
                    if (isExist == null)
                    {
                        FileSystemWatcher watcher = new FileSystemWatcher(path.Path);
                        watcher.IncludeSubdirectories = path.IncludeSubdirectories;
                        watcher.NotifyFilter = NotifyFilters.LastAccess
                                         | NotifyFilters.LastWrite
                                         | NotifyFilters.FileName
                                         | NotifyFilters.DirectoryName;
                        watcher.Changed += Watcher_Changed;
                        watcher.Created += Watcher_Created;
                        watcher.EnableRaisingEvents = true;
                        FileSystemWatchers.Add(watcher);
                    }
                } 
            }
        }

        private void StopFileSystemWatchers()
        {
            if (FileSystemWatchers != null)
            {
                foreach (var watcher in FileSystemWatchers)
                {
                    watcher.EnableRaisingEvents = false;
                    watcher.Dispose();
                }
                FileSystemWatchers.Clear();
            }
        }

        private void Watcher_Created(object sender, FileSystemEventArgs e)
        {
            if (IsIgnore(e.FullPath))
                return;
            FileAttributes attr = File.GetAttributes(e.FullPath);
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                var log = new ChangesLog()
                {
                    FilePath = e.FullPath,
                    WatcherPath = ((FileSystemWatcher)sender).Path,
                    AddTime = DateTime.Now,
                    Action = e.ChangeType.ToString(),
                    AddedToSync = 0
                };
                LogHelper.AddChangeLog(log);
                LogHelper.AddFile(e.FullPath);
            }
        }

        private void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (IsIgnore(e.FullPath))
                return;
            FileAttributes attr = File.GetAttributes(e.FullPath);
            if (!attr.HasFlag(FileAttributes.Directory))
            {
                var log = new ChangesLog()
                {
                    FilePath = e.FullPath,
                    WatcherPath = ((FileSystemWatcher)sender).Path,
                    AddTime = DateTime.Now,
                    Action = e.ChangeType.ToString(),
                    AddedToSync = 0
                };
                LogHelper.AddChangeLog(log);
                LogHelper.AddFile(e.FullPath);
            }
        }

        private void timerChangeLog_Tick(object sender, EventArgs e)
        {
            timerChangeLog.Interval = 5000;
            if (ChangesBusy)
                return;
            if (chkChangesAutoRefresh.Checked)
            {
                Task.Run(() => { ShowChanges(); });
            }
            if (chkAutoSendToSync.Checked)
            {
                Task.Run(() => { SendToSync(0); });
            }
        }

        private void btnChangesRefresh_Click(object sender, EventArgs e)
        {
            Task.Run(() => { ShowChanges(); });
        }

        private void ShowChanges()
        {
            AsyncShowChanges();
        }

        private void AsyncShowChanges()
        {
            if (grdChanges.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    AsyncShowChanges();
                }));
            }
            else
            {
                grdChanges.DataSource = LogHelper.ReadChangeLog().Take(100).ToList();
            }
        }

        private void SendToSync(int status)
        {
            this.ChangesBusy = true;
            List<DestinationsServer> servers;
            var changes = LogHelper.ReadNotAddedChanges();
            Parallel.ForEach(changes, (change) => {
                if (status == 0)
                    servers = Setting.CurrentSetting.Servers.Where(s => s.IsActive).ToList();
                if (status == 1)
                    servers = GetServer();
                foreach (var server in GetServer())
                {
                    var log = new SyncLog();
                    log.AddTime = DateTime.Now;
                    log.SourcePath = change.FilePath;
                    log.DestinationName = server.Name;
                    log.DestinationPath = Path.GetPathRoot(server.Path) + change.FilePath.Substring(2, change.FilePath.Length - 2);
                    log.DestinationRoot = server.Path;
                    var result = LogHelper.AddSync(log);
                    if (result)
                    {
                        LogHelper.UpdateChangesStatus(change.Id, 1);
                    }
                }
            });
            this.ChangesBusy = false;
        }

        private void btnAddToSync_Click(object sender, EventArgs e)
        {
            Task.Run(() => { SendToSync(1); });
        }

        private List<DestinationsServer> GetServer()
        {
            if (chkServers.GetItemChecked(0))
            {
                return Setting.CurrentSetting.Servers.Where(s=>s.IsActive).ToList();
            }
            if (chkServers.GetItemChecked(1))
            {
                return Setting.CurrentSetting.Servers;
            }
            var servs = new List<DestinationsServer>();
            for(var index=0;index < chkServers.Items.Count; index++)
            {
                if (chkServers.GetItemChecked(index))
                {
                    var isExist = Setting.CurrentSetting.Servers.Find(s => s.Name == chkServers.Items[index].ToString());
                    if (isExist != null)
                        servs.Add(isExist); 
                }
            }
            return servs;
        }

        private void timerSyncLog_Tick(object sender, EventArgs e)
        {
            timerSyncLog.Interval = 5000;
            if (this.SyncBusy)
                return;
            
            if (chkSyncAutoRefresh.Checked)
            {
                Task.Run(()=> { ShowNotSynced(); });
            }
            if (chkAutoSend.Checked)
            {
                Task.Run(() => { Sync(); });
            }
            
            
        }

        private void btnSyncRefresh_Click(object sender, EventArgs e)
        {
            Task.Run(() => { ShowNotSynced(); });
        }

        private void ShowNotSynced()
        {
            AsyncShowNotSynced();
        }

        private void AsyncShowNotSynced()
        {
            if (grdSyncLog.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    AsyncShowNotSynced();
                }));
            }
            else
            {
                grdSyncLog.DataSource = LogHelper.ReadNotSynced().Take(100).ToList();
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Task.Run(() => { Sync(); });
        }

        private void Sync()
        {
            this.SyncBusy = true;
            var files = LogHelper.ReadNotSynced();
            Parallel.ForEach(files, (file) => {
                try
                {
                    var info = new FileInfo(Path.GetDirectoryName(file.DestinationPath));
                    if (!info.Exists)
                    {
                        Directory.CreateDirectory(info.FullName);
                    }
                    File.Copy(file.SourcePath, file.DestinationPath, true);
                    file.SyncStatus = 1;
                    LogHelper.UpdateSyncStatus(file);
                }
                catch (Exception ex)
                {
                    file.SyncStatus = 2;
                    file.Message = ex.Message;
                    LogHelper.UpdateSyncStatus(file);
                }
            });
            this.SyncBusy = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Setting.CurrentSetting= LogHelper.AddSetting(Setting.CurrentSetting);
            FillServersChk();
        }

        private void btnStartWatching_Click(object sender, EventArgs e)
        {
            StartWatching();
        }

        private void StartWatching()
        {
            if (FilemWatcherStatus == 0)
            {
                FilemWatcherStatus = 1;
                btnStartWatching.Text = "End Watching";
                btnStartWatching.ForeColor = Color.Red;
                CreaetFileSystemWatchers();
            }
            else
            {
                FilemWatcherStatus = 0;
                btnStartWatching.Text = "Start Watching";
                btnStartWatching.ForeColor = Color.Green;
                StopFileSystemWatchers();
            }
        }

        private void FillServersChk()
        {
            chkServers.Items.Clear();
            if(Setting.CurrentSetting.Servers != null)
            {
                foreach(var srv in Setting.CurrentSetting.Servers)
                {
                    chkServers.Items.Add(srv.Name);
                }
                chkServers.Items.Insert(0, "Active Servers");
                chkServers.Items.Insert(1,"ALL Servers");
                chkServers.SetItemChecked(0,true);
            }
        }

        private List<String> GetFiles(string sDir)
        {
            List<String> files = new List<String>();
            try
            {
                foreach (string f in Directory.GetFiles(sDir))
                {
                    files.Add(f);
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    files.AddRange(GetFiles(d));
                }
            }
            catch (System.Exception excpt)
            {
                
            }
            return files;
        }

        private void btnFileScan_Click(object sender, EventArgs e)
        {
            if (this.FileScanBusy)
                return;
            Task.Run(() => { FileScan(0); });
        }

        private void btnFileIndexing_Click(object sender, EventArgs e)
        {
            Task.Run(() => { FileScan(1); });
        }

        private void FileScan(int action)
        {
            this.FileScanBusy = true;
            var setting = Setting.CurrentSetting;
            foreach (var path in setting.Paths.FindAll(p => p.IsActive == true))
            {
                Parallel.ForEach(GetFiles(path.Path), (file, a) =>
                {
                    if (!IsIgnore(file))
                    {
                        var status = LogHelper.AddFile(file);
                    if (status && action == 0)
                        {
                            var log = new ChangesLog()
                            {
                                FilePath = file,
                                WatcherPath = "FileScan",
                                AddTime = DateTime.Now,
                                Action = "FileScan",
                                AddedToSync = 0
                            };
                            LogHelper.AddChangeLog(log);
                        }
                    }
                });
            }
            this.FileScanBusy = false;
        }

        private void btnDeleteChecked_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in grdChanges.Rows)
            {
                var ischecked = row.Cells["ChangesChk"].Value;
                if (ischecked != null && (bool)ischecked) 
                {
                    ObjectId logId = (ObjectId)row.Cells["Id"].Value;
                    LogHelper.DeleteChanges(logId);
                }
            }
            Task.Run(() => { ShowChanges(); });
        }

        private void btnDelAllChanges_Click(object sender, EventArgs e)
        {
            LogHelper.DeleteAllChanges();
            Task.Run(() => { ShowChanges(); });
        }

        private void topMostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = topMostToolStripMenuItem.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerBusy_Tick(object sender, EventArgs e)
        {
            if (this.ChangesBusy || this.SyncBusy || this.FileScanBusy)
                imgLoading.Visible = true;
            else
                imgLoading.Visible = false;
        }

        private bool IsIgnore(string path)
        {
            try
            {
                foreach (var ignor in Setting.CurrentSetting.Ignores)
                {
                    var regex = new Regex(ignor.IgnoreRegex);
                    var matches = regex.Matches(path);
                    if (matches.Count > 0)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btnSyncDelCheck_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdSyncLog.Rows)
            {
                var ischecked = row.Cells["chkSync"].Value;
                if (ischecked != null && (bool)ischecked)
                {
                    ObjectId logId = (ObjectId)row.Cells["Syncid"].Value;
                    LogHelper.SyncDelete(logId);
                }
            }
            Task.Run(() => { ShowNotSynced(); });
        }

        private void btnSyncDelAll_Click(object sender, EventArgs e)
        {
            LogHelper.SyncDeleteAll();
            Task.Run(() => { ShowNotSynced(); });
        }
    }
}
