using RandomArticleGenerator.Adapters.OuterGatewayAdapter;
using RandomArticleGenerator.Domain.Quote;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Quote
{
    public class QuotableGateway : IQuotesGateway
    {
        private readonly IResourceResolver _resourceResolver;
        public readonly string ApiUrl = "api.quotable.io";

        public QuotableGateway(IResourceResolver resourceResolver)
        {
            _resourceResolver = resourceResolver;
        }

        private string GetApiUrl()
        {
            return $"{ApiUrl}/random";
        }

        public async Task<QuoteEntity> GetQuote()
        {
            string apiUrl = GetApiUrl();
            QuoteEntity quote = await _resourceResolver.RetrieveData<QuoteEntity>(apiUrl);
            return quote;
        }
    }
}
