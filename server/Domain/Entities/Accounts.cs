using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Domain.Entities
{
    public class Accounts
    {
        public ObjectId _id { get; set; }
        [BsonElement("accountName")]
        public string AccountName { get; set; } = null!;
        [BsonElement("accountDescription")]
        public string AccountDescription { get; set; } = null!;

        public Accounts(string AccountName, string AccountDescription)
        {
            this.AccountName = AccountName;
            this.AccountDescription = AccountDescription;
        }
    }
}
