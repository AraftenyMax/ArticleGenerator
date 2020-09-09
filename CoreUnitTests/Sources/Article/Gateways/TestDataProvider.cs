using RandomArticleGenerator.Domain.Article;
using RandomArticleGenerator.Domain.Image;
using RandomArticleGenerator.Domain.News;
using RandomArticleGenerator.Domain.Quote;
using RandomArticleGenerator.Domain.Spaceships;
using RandomArticleGenerator.Domain.Weather;

namespace CoreUnitTests.Gateways.Article
{
    class TestDataProvider
    {
        public ImageEntity GetImageEntity()
        {
            ImageEntity image = new ImageEntity
            {
                Url = "some-url.com",
                Bitmap = new byte[20, 20]
            };
            return image;
        }

        public NewsEntity GetNewsEntity()
        {
            NewsEntity news = new NewsEntity
            {
                Author = "Some really cool author",
                Description = "It's very good description. All of the stuff will be explained later",
                Image = new byte[20, 20],
                Url = "Some really useful url"
            };
            return news;
        }

        public QuoteEntity GetQuoteEntity()
        {
            QuoteEntity quote = new QuoteEntity
            {
                Text = "Nothing is eternal under the moon",
                Author = "William Shakespear"
            };
            return quote;
        }

        public WeatherEntity GetWeatherEntity()
        {
            WeatherEntity weather = new WeatherEntity
            {
                Longitude = 29,
                Latitude = 29,
                Timezone = "some time zone",
                Sunrise = 26158276,
                Sunset = 22387342,
                Pressure = 1004,
                Humidity = 93,
                Clouds = 2,
                Visibility = 16093,
                WindDegree = 305,
                WindSpeed = 22.5
            };
            return weather;
        }

        public SpaceshipEntity GetSpaceshipEntity()
        {
            SpaceshipEntity spaceship = new SpaceshipEntity
            {
                Name = "Boston dynamics(dummy name)",
                Image = new byte[20, 20],
                Active = true,
                Height = 22,
                Mass = 21000
            };
            return spaceship;
        }

        public ArticleEntity CreateTestArticle()
        {
            ArticleEntity articleEntity = new ArticleEntity();

            articleEntity.Image = GetImageEntity();
            articleEntity.News = GetNewsEntity();
            articleEntity.Quote = GetQuoteEntity();
            articleEntity.Spaceship = GetSpaceshipEntity();
            articleEntity.Weather = GetWeatherEntity();

            return articleEntity;
        }
    }
}
