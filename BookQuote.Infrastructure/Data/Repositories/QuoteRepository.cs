using BookQuote.Core.Entities;
using BookQuote.Core.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Infrastructure.Data.Repositories
{
    public class QuoteRepository
    {
        private IMongoCollection<Quote> collection;
        public QuoteRepository(IDbContext dbContext)
        {
            collection = dbContext.GetCollection<Quote>(typeof(Quote).Name);
        }

        // Create
        public void Add(Quote quote)
        {

        }
        public void Add(List<Quote> quotes)
        {

        }
        // Read
        public void Get()
        {

        }

        // Update
        public void Update()
        {

        }
        // Delete
        public void Delete()
        {

        }
    }
}
