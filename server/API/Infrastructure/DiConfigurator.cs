using Application.Services;
using Domain.Entities;
using Application.Services;
using Application.Interfaces;

namespace API.Infrastructure
{
    public class DiConfigurator 
    {
        private readonly IConfiguration _configuration;

        public DiConfigurator(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IServiceCollection container)
        {   //Add Mongo Db Service
            container.Configure<Accounts>(_configuration.GetSection("MongoDB"));
            container.AddSingleton<MongoDBServices>();

            //Add API Services here
            container.AddScoped(typeof(IAccountsServices), typeof(AccountsService));
        }
    }
}
