using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using MongoDB.Bson;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MongoClient client = new MongoClient("mongodb+srv://jdsantil:Jbdeha5z*@cluster0.yhkrx.mongodb.net/?retryWrites=true&w=majority");

            List<string> databases = client.ListDatabaseNames().ToList();

            foreach (string database in databases)
            {
                Console.WriteLine(database);
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
