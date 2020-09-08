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
            return article;
        }

        private async ArticleEntity GetRequiredData()
        {
            Task<ImageEntity> imageTask = GetImage();
            Task<WeatherEntity> weatherTask = GetWeather();
            Task<NewsEntity> newsEntity = GetNews();
            Task<QuoteEntity> quoteEntity = GetQuote();
            Task<SpaceshipEntity> spaceshipEntity = GetSpaceship();
            
        }

        private async Task<ImageEntity> GetImage()
        {
            ImageEntity image = ImageGateway.GetImage();
            return image;
        }

        private async Task<WeatherEntity> GetWeather()
        {
            WeatherEntity weather = await WeatherGateway.GetWeatherForRandomCity();
            return weather;
        }

        private async Task<NewsEntity> GetNews()
        {
            NewsEntity news = NewsGateway.GetRandomNews();
            return news;
        }

        private async Task<QuoteEntity> GetQuote()
        {
            QuoteEntity quote = await QuotesGateway.GetQuote();
            return quote;
        }

        private async Task<SpaceshipEntity> GetSpaceship()
        {
            SpaceshipEntity spaceship = SpaceshipsGateway.GetRandomSpaceship();
            return spaceship;
        }
    }
}
