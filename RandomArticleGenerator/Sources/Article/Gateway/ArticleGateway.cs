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
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.Article
{
    public class ArticleGateway : IArticleGateway
    {
        private IImageGateway ImageGateway;
        private INewsGateway NewsGateway;
        private IQuotesGateway QuotesGateway;
        private ISpaceshipsGateway SpaceshipsGateway;
        private IWeatherGateway WeatherGateway;

        public ArticleGateway(IImageGateway imageGateway,
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
            GetRequiredData(article);
            return article;
        }

        private ArticleEntity GetRequiredData(ArticleEntity article)
        {
            Task imageTask = GetImage(article);
            Task weatherTask = GetWeather(article);
            Task newsTask = GetNews(article);
            Task quoteTask = GetQuote(article);
            Task spaceshipTask = GetSpaceship(article);
            Task[] awaitedTasks = new Task [] { imageTask, weatherTask, newsTask, quoteTask, spaceshipTask };
            Task.WaitAll(awaitedTasks);
            return article;
        }

        private async Task GetImage(ArticleEntity article)
        {
            ImageEntity image = await ImageGateway.GetImage();
            article.Image = image;
        }

        private async Task GetWeather(ArticleEntity article)
        {
            WeatherEntity weather = await WeatherGateway.GetWeatherForRandomCity();
            article.Weather = weather;
        }

        private async Task GetNews(ArticleEntity article)
        {
            NewsEntity news = await NewsGateway.GetRandomNews();
            article.News = news;
        }

        private async Task GetQuote(ArticleEntity article)
        {
            QuoteEntity quote = await QuotesGateway.GetQuote();
            article.Quote = quote;
        }

        private async Task GetSpaceship(ArticleEntity article)
        {
            SpaceshipEntity spaceship = await SpaceshipsGateway.GetRandomSpaceship();
            article.Spaceship = spaceship;
        }
    }
}
