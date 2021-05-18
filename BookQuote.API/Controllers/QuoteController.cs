using BookQuote.Core.Entities;
using BookQuote.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookQuote.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private IQuoteRepository quoteRepository;

        public QuoteController(IQuoteRepository quoteRepository)
        {
            this.quoteRepository = quoteRepository;
        }

        [HttpPost]
        public void PostQuote(Quote quote)
        {
            quoteRepository.Add(quote);
        }

        [HttpGet]
        public ActionResult<List<Quote>> GetAll()
        {
            return quoteRepository.GetAll();
        }
        //[HttpPut]
    }
}
