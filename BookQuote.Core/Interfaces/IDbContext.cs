using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Core.Interfaces
{
    public interface IDbContext
    {
        public IMongoCollection<T> GetCollection<T>(string name);
    }
}
