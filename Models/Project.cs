using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.HRMS.Common.Models
{
    public class Project
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProjectName { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> Employees { get; set; }
    }
}
