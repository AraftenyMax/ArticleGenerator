using RandomArticleGenerator.Domain.Image;
using RandomArticleGenerator.Domain.News;
using RandomArticleGenerator.Domain.Quote;
using RandomArticleGenerator.Domain.Spaceships;
using RandomArticleGenerator.Domain.Weather;

namespace RandomArticleGenerator.Domain.Article
{
   public class ArticleEntity
    {
        public ImageEntity Image;
        public NewsEntity News;
        public QuoteEntity Quote;
        public SpaceshipEntity Spaceship;
        public WeatherEntity Weather;
    }
}
