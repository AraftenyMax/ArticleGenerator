using Moq;
using NUnit.Framework;
using RandomArticleGenerator.Domain.Article;
using RandomArticleGenerator.Gateways.Article;
using RandomArticleGenerator.Gateways.Image;
using RandomArticleGenerator.Gateways.News;
using RandomArticleGenerator.Gateways.Quote;
using RandomArticleGenerator.Gateways.Spaceships;
using RandomArticleGenerator.Gateways.Weather;

namespace CoreUnitTests.Gateways.Article
{
    class ArticleGatewayTests
    {
        TestDataProvider TestDataProvider = new TestDataProvider();
        IArticleGateway articleGateway;
        Mock<IWeatherGateway> weatherGatewayMock;
        Mock<ImageGateway> imageGatewayMock;
        Mock<INewsGateway> newsGatewayMock;
        Mock<IQuotesGateway> quoteGatewayMock;
        Mock<ISpaceshipsGateway> spaceShipsGatewayMock;

        [SetUp]
        public void SetUp()
        {
            weatherGatewayMock = new Mock<IWeatherGateway>();
            imageGatewayMock = new Mock<ImageGateway>();
            newsGatewayMock = new Mock<INewsGateway>();
            quoteGatewayMock = new Mock<IQuotesGateway>();
            spaceShipsGatewayMock = new Mock<ISpaceshipsGateway>();

            weatherGatewayMock.Setup(mock => mock.GetWeatherForRandomCity())
                .Returns(TestDataProvider.GetWeatherEntity());
            imageGatewayMock.Setup(mock => mock.GetImage())
                .Returns(TestDataProvider.GetImageEntity());
            newsGatewayMock.Setup(mock => mock.GetRandomNews())
                .Returns(TestDataProvider.GetNewsEntity());
            quoteGatewayMock.Setup(mock => mock.GetQuote())
                .Returns(TestDataProvider.GetQuoteEntity());
            spaceShipsGatewayMock.Setup(mock => mock.GetRandomSpaceship())
                .Returns(TestDataProvider.GetSpaceshipEntity());

            articleGateway = new ArticleGateway(imageGatewayMock.Object, newsGatewayMock.Object,
                quoteGatewayMock.Object, spaceShipsGatewayMock.Object, weatherGatewayMock.Object);
        }

        [Test]
        public void AggregatesInformationFromGateways()
        {
            ArticleEntity actualArticle = articleGateway.GetArticle();
            ArticleEntity expectedArticle = TestDataProvider.CreateTestArticle();
            Assert.AreEqual(expectedArticle, actualArticle);
        }
    }
}
