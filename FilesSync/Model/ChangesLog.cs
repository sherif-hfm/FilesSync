using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSync.Model
{
    public class ChangesLog
    {
        public ObjectId Id { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime AddTime { get; set; }

        public string FilePath { get; set; }

        public string WatcherPath { get; set; }

        public string Action { get; set; }

        public int AddedToSync { get; set; }
    }
}
