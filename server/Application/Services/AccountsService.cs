using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services;
using MongoDB.Driver;
using MongoDB.Bson;
using Application.Interfaces;
using Persistence.Repositories;
using Microsoft.Extensions.Options;
using Persistence.Models;

namespace Application.Services
{
    public class AccountsService : IAccountsServices
    {
        private readonly IMongoCollection<Accounts> _accountCollection;
        public AccountsService(
        IOptions<MongoDBSettings> MongoDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                "mongodb+srv://jdsantil:<Password>@cluster0.yhkrx.mongodb.net/?retryWrites=true&w=majority");

            var mongoDatabase = mongoClient.GetDatabase(
                "financeDB");
            _accountCollection = mongoDatabase.GetCollection<Accounts>(
                "accounts");

        }

        private readonly AccountsRepositories _locationRepository;
        public async Task<List<Accounts>> GetAccounts() =>
           await _accountCollection.Find(_ => true).ToListAsync(); 

    }
}
