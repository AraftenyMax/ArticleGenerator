using RandomArticleGenerator.Domain.Article;
using RandomArticleGenerator.Domain.Image;
using RandomArticleGenerator.Domain.News;
using RandomArticleGenerator.Domain.Quote;
using RandomArticleGenerator.Domain.Spaceships;
using RandomArticleGenerator.Domain.Weather;
using RandomArticleGenerator.Gateways.Image;
using RandomArticleGenerator.Gateways.News;
using RandomArticleGenerator.Gateways.Quote;
using RandomArticleGenerator.Gateways.Spaceships;
using RandomArticleGenerator.Gateways.Weather;

namespace RandomArticleGenerator.Gateways.Article
{
    public class ArticleGateway : IArticleGateway
    {
        private ImageGateway ImageGateway;
        private INewsGateway NewsGateway;
        private IQuotesGateway QuotesGateway;
        private ISpaceshipsGateway SpaceshipsGateway;
        private IWeatherGateway WeatherGateway;

        public ArticleGateway(ImageGateway imageGateway,
            INewsGateway newsGateway, IQuotesGateway quotesGateway,
            ISpaceshipsGateway spaceshipsGateway, IWeatherGateway weatherGateway)
        {
            this.ImageGateway = imageGateway;
            this.NewsGateway = newsGateway;
            this.QuotesGateway = quotesGateway;
            this.SpaceshipsGateway = spaceshipsGateway;
            this.WeatherGateway = weatherGateway;
        }

        public ArticleEntity GetArticle()
        {
            ArticleEntity article = new ArticleEntity();
            GetImage(article);
            GetWeather(article);
            GetQuote(article);
            GetNews(article);
            GetQuote(article);
            GetSpaceship(article);
            return article;
        }

        private void GetImage(ArticleEntity article)
        {
            ImageEntity image = ImageGateway.GetImage();
            article.Image = image;
        }

        private void GetWeather(ArticleEntity article)
        {
            WeatherEntity weather = WeatherGateway.GetWeatherForRandomCity();
            article.Weather = weather;
        }

        private void GetNews(ArticleEntity article)
        {
            NewsEntity news = NewsGateway.GetRandomNews();
            article.News = news;
        }

        private void GetQuote(ArticleEntity article)
        {
            QuoteEntity quote = QuotesGateway.GetQuote();
            article.Quote = quote;
        }

        private void GetSpaceship(ArticleEntity article)
        {
            SpaceshipEntity spaceship = SpaceshipsGateway.GetRandomSpaceship();
            article.Spaceship = spaceship;
        }
    }
}
