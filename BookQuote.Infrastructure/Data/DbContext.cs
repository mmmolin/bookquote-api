using BookQuote.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace BookQuote.Infrastructure.Data
{
    public class DbContext : IDbContext
    {
        private readonly IMongoClient client;
        private IMongoDatabase database;
        public DbContext(IConfiguration configuration)
        {
            this.client = new MongoClient(configuration["BookQuoteDatabaseSettings:ConnectionString"]);
            database = client.GetDatabase(configuration["BookQuoteDatabaseSettings:DatabaseName"]);
        }
        public IMongoCollection<T> GetCollection<T>(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                return null;
            }

            return database.GetCollection<T>(name);
        }
    }
}
