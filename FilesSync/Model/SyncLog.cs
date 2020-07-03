using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSync.Model
{
    public class SyncLog
    {
        public ObjectId Id { get; set; }
        
        public string DestinationName { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime AddTime { get; set; }

        public string SourcePath { get; set; }

        public string DestinationRoot { get; set; }

        public string DestinationPath { get; set; }

        public int SyncStatus { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? SyncTime { get; set; }

        public string Message { get; set; }
    }
}
