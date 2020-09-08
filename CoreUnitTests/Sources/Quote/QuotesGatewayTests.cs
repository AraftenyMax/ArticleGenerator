using Moq;
using NUnit.Framework;
using RandomArticleGenerator.Adapters.OuterGatewayAdapter;
using RandomArticleGenerator.Domain.Quote;
using RandomArticleGenerator.Gateways.Quote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreUnitTests.Sources.Quote
{
    class QuotesGatewayTests
    {
        IQuotesGateway quotesGateway;
        Mock<IResourceResolver> resolver;
        [SetUp]
        public void SetUp()
        {
            resolver = new Mock<IResourceResolver>();
            quotesGateway = new QuotableGateway(resolver.Object);
        }

        [Test]
        public async Task RequestsDataFromAPI()
        {
            QuoteEntity expected = new QuoteEntity
            {
                Text = "This is text",
                Author = "This is author",
            };
            resolver.Setup(mock => mock.RetrieveData<QuoteEntity>(It.IsAny<string>())).ReturnsAsync(expected);
            QuoteEntity actual = await quotesGateway.GetQuote();
            Assert.AreEqual(expected, actual);
        }
    }
}
