using RandomArticleGenerator.Domain.Quote;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Quote
{
    public interface QuotesGateway
    {
        QuoteEntity GetQuote();
    }
}
