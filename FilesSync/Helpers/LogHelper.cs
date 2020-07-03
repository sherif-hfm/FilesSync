using FilesSync.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSync.Helpers
{
    public static class LogHelper
    {
        static string mongoConn = ConfigurationManager.AppSettings["Mongo.Cnn"];
        static string db = ConfigurationManager.AppSettings["Mongo.Db"];
        static Riyadh.EServices.MongoDB.Helper.MongoDbHelper mongo = new Riyadh.EServices.MongoDB.Helper.MongoDbHelper(new Riyadh.EServices.MongoDB.Helper.ConnectionOptions() { ConnectionString = mongoConn, DatabaseName = db });

        public static void AddChangeLog(ChangesLog log)
        {
           
            var isexist = mongo.GetData<ChangesLog>("ChangesLog", l => l.FilePath == log.FilePath && l.AddedToSync == 0);
            if (isexist.Count() == 0)
                mongo.AddOne<ChangesLog>("ChangesLog", log);
        }

        public static List<ChangesLog> ReadChangeLog()
        {
            var data = mongo.GetData<ChangesLog>("ChangesLog", l =>  l.AddedToSync != 1);
            return data;


        }

        public static List<ChangesLog> ReadNotAddedChanges()
        {
            var data = mongo.GetData<ChangesLog>("ChangesLog", l => l.AddedToSync == 0);
            return data;
        }

        public static void UpdateChangesStatus(ObjectId  logId,int status)
        {
            
            var newValues = new Dictionary<string, object>();
            newValues.Add("AddedToSync", 1);
            mongo.UpdateMany<ChangesLog>("ChangesLog", c => c.Id == logId, newValues);
        }

        public static void DeleteChanges(ObjectId logId)
        {
            mongo.DeleteOne<ChangesLog>("ChangesLog", c => c.Id == logId);
        }

        public static void DeleteAllChanges()
        {
            mongo.DeleteMany<ChangesLog>("ChangesLog", c =>  c.AddedToSync == 0);
        }

        public static bool AddSync(SyncLog log)
        {
            try
            {
                var isexist = mongo.GetData<SyncLog>("SyncLog", l => l.SourcePath == log.SourcePath && l.DestinationPath == log.DestinationPath && l.SyncStatus == 0);
                if (isexist.Count() == 0)
                    mongo.AddOne<SyncLog>("SyncLog", log);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<SyncLog> ReadNotSynced()
        {
            var data = mongo.GetData<SyncLog>("SyncLog", l => l.SyncStatus != 1);
            return data;
        }

        public static void UpdateSyncStatus(SyncLog log)
        {
            var newValues = new Dictionary<string, object>();
            newValues.Add("SyncTime", DateTime.Now);
            newValues.Add("SyncStatus", log.SyncStatus);
            newValues.Add("Message", log.Message);
            mongo.UpdateMany<SyncLog>("SyncLog", c => c.Id == log.Id, newValues);
        }

        public static void SyncDelete(ObjectId logId)
        {
            mongo.DeleteOne<SyncLog>("SyncLog", s => s.Id == logId);
        }

        public static void SyncDeleteAll()
        {
            mongo.DeleteMany<SyncLog>("SyncLog", s => s.SyncStatus == 0);
        }

        public static Setting AddSetting(Setting info)
        {
            Setting result;
            try
            {
                var isexist = mongo.GetData<Setting>("Setting", l => l.Id != null);
                if (isexist.Count() == 0)
                {
                    result= mongo.AddOne<Setting>("Setting", info);
                }
                else
                {
                    mongo.DeleteOne<Setting>("Setting", s => s.Id == info.Id);
                    result= mongo.AddOne<Setting>("Setting", info);
                }
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Setting GetSetting()
        {
            try
            {
                var data = mongo.GetData<Setting>("Setting", l => l.Id != null);
                if (data.Count() > 0)
                    return data.First();
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool AddFile(string   filePath)
        {
            try
            {
                FileInfo info = new FileInfo(filePath);
                DateTime fileDate = File.GetLastWriteTime(filePath);
                var isexist = mongo.GetData<FileInfos>("Files", f => f.FilePath == filePath );
                if (isexist.Count() == 0)
                {
                    mongo.AddOne<FileInfos>("Files", new FileInfos() { FilePath = filePath, FileDate = fileDate, FileSize = info.Length.ToString(), LastUpdate = DateTime.Now });
                    return true;
                }
                else
                {
                    var crFile = isexist.First();
                    if (Convert.ToInt32 ((crFile.FileDate - fileDate).TotalSeconds) != 0 || crFile.FileSize != info.Length.ToString())
                    {
                        var newValues = new Dictionary<string, object>();
                        newValues.Add("FileDate", fileDate);
                        newValues.Add("FileSize", info.Length.ToString());
                        newValues.Add("LastUpdate", DateTime.Now);
                        mongo.UpdateMany<FileInfos>("Files", s => s.Id == crFile.Id, newValues);
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

    }
}
