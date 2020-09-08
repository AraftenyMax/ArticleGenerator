using RandomArticleGenerator.Domain.Quote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Quote
{
    public interface IQuotesGateway
    {
        Task<QuoteEntity> GetQuote();
    }
}
