using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using Domain.Entities;
using Persistence.Models;
using Microsoft.Extensions.Options;

namespace Application.Services
{
    public class MongoDBServices
    {

        private readonly IMongoCollection<Accounts> _accountCollection;
        public MongoDBServices(
        IOptions<MongoDBSettings> MongoDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                MongoDatabaseSettings.Value.ConnectionURI);

            var mongoDatabase = mongoClient.GetDatabase(
                MongoDatabaseSettings.Value.DatabaseName);
            _accountCollection = mongoDatabase.GetCollection<Accounts>(
                MongoDatabaseSettings.Value.CollectionName);

        }


    }
}
