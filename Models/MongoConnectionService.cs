using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBS.HRMS.Common.Models
{
    public class MongoConnectionService
    {
        private readonly IConfiguration configuration;
        public IMongoDatabase MongoDataBase { get; set; }
        public MongoConnectionService(IConfiguration configuration)
        {
            this.configuration = configuration;
            var mongoClient = new MongoClient(this.configuration["HRMSDatabaseSettings:ConnectionString"]);
            MongoDataBase = mongoClient.GetDatabase(this.configuration["HRMSDatabaseSettings:DatabaseName"]);
        }
    }
}
