using RandomArticleGenerator.Domain.Quote;
using System;

namespace RandomArticleGenerator.Gateways.Quote
{
    class QuotableGateway : IQuotesGateway
    {
        public readonly string ApiUrl = "api.quotable.io";
        public QuoteEntity GetQuote()
        {
            throw new NotImplementedException();
        }
    }
}
