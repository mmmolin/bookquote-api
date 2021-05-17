using BookQuote.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Core.Interfaces
{
    public interface IQuoteRepository
    {
        public void Add(Quote quote);
        public void Add(IList<Quote> quotes);
        public List<Quote> Find(string word);
        //public void Update();
        //public void Delete();
    }
}
