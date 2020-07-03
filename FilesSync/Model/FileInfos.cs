using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesSync.Model
{
    public class FileInfos
    {
        public ObjectId Id { get; set; }

        public string FilePath { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime  FileDate { get; set; }

        public string   FileSize { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime LastUpdate { get; set; }
    }
}
