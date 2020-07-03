using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSync.Model
{
    public class Setting
    {

        public Setting()
        {
            this.Paths = new List<WatchersPath>();
            this.Servers = new List<DestinationsServer>();
            this.Ignores = new List<Ignore>();
        }

        [Browsable(false)]
        public ObjectId Id { get; set; }

        public static Setting CurrentSetting;

        public List<WatchersPath> Paths { get; set; }

        public List<DestinationsServer> Servers { get; set; }

        public List<Ignore> Ignores { get; set; }

        public bool AutoSendToSync { get; set; }

        public bool AutoSync { get; set; }

        public bool AutoStartFileWatching { get; set; }

    }

    public class WatchersPath
    {
        public WatchersPath()
        {
            
        }

        public string Path { get; set; }

        public bool IsActive { get; set; }

        
    }

    public class DestinationsServer
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public bool IsActive { get; set; }
    }

    public class Ignore
    {
        public string IgnoreRegex { get; set; }
    }
}
