using RandomArticleGenerator.Domain.Image;
using RandomArticleGenerator.Domain.News;
using RandomArticleGenerator.Domain.Quote;
using RandomArticleGenerator.Domain.Spaceships;
using RandomArticleGenerator.Domain.Weather;
using System;

namespace RandomArticleGenerator.Domain.Article
{
   public class ArticleEntity : IEquatable<ArticleEntity>
    {
        public ImageEntity Image;
        public NewsEntity News;
        public QuoteEntity Quote;
        public SpaceshipEntity Spaceship;
        public WeatherEntity Weather;

        public bool Equals(ArticleEntity other)
        {
            bool images = Image.Equals(other.Image);
            bool news = News.Equals(other.News);
            bool quotes = Quote.Equals(other.Quote);
            bool spaceship = Spaceship.Equals(other.Spaceship);
            bool weather = Weather.Equals(other.Weather);
            return images && news && quotes && spaceship && weather;
        }
    }
}
