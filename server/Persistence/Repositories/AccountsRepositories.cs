using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Persistence.Models;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Persistence.Repositories
{

    public class AccountsRepositories
    {
        private readonly IMongoCollection<Accounts> _accountCollection;
        public async Task<List<Accounts>> GetAccounts()
        {
            return await _accountCollection.Find(_ => true).ToListAsync();
        }
    }
}
