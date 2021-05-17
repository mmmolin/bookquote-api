using BookQuote.Core.Entities;
using BookQuote.Core.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Infrastructure.Data.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private IMongoCollection<Quote> collection;
        public QuoteRepository(IDbContext dbContext)
        {
            collection = dbContext.GetCollection<Quote>(typeof(Quote).Name);
        }

        public void Add(Quote quote)
        {
            collection.InsertOne(quote);
        }

        public void Add(IList<Quote> quotes)
        {
            collection.InsertMany(quotes);
        }

        public List<Quote> Find(string word)
        {
            var wordSearch = collection.Find(Builders<Quote>.Filter.Text(word)).ToList();
            return wordSearch;
        }
    }
}
