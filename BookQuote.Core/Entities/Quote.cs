using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Core.Entities
{
    [MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElements]
    public class Quote
    {
        public string Book { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

    }
}
