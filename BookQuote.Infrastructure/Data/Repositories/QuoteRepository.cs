using BookQuote.Core.Entities;
using BookQuote.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Infrastructure.Data.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private IMongoCollection<Quote> collection;
        public QuoteRepository(IConfiguration configuration, IDbContext dbContext)
        {
            collection = dbContext.GetCollection<Quote>(configuration["BookQuoteDataBaseSettings:CollectionName"]);
        }

        public void Add(Quote quote)
        {
            collection.InsertOne(quote);
        }

        public void Add(IList<Quote> quotes)
        {
            collection.InsertMany(quotes);
        }

        public List<Quote> GetAll()
        {
            var entities = collection.Find(new BsonDocument()).ToList();
            return entities;
        }

        public List<Quote> Find(string word)
        {
            var wordSearch = collection.Find(Builders<Quote>.Filter.Text(word)).ToList();
            return wordSearch;
        }
    }
}
