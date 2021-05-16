using System;
using System.Collections.Generic;
using System.Text;

namespace BookQuote.Core.Entities
{
    public class Quote
    {
        public string Id { get; set; }
        public string Book { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

    }
}
