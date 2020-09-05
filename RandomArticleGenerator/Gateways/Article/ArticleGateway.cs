using RandomArticleGenerator.Domain.Article;
using RandomArticleGenerator.Gateways.Image;
using RandomArticleGenerator.Gateways.News;
using RandomArticleGenerator.Gateways.Quote;
using RandomArticleGenerator.Gateways.Spaceships;
using RandomArticleGenerator.Gateways.Weather;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.Article
{
    public class ArticleGateway : IArticleGateway
    {
        private ImageGateway ImageGateway;
        private NewsGateway NewsGateway;
        private QuotesGateway QuotesGateway;
        private SpaceshipsGateway SpaceshipsGateway;
        private WeatherGateway WeatherGateway;

        public ArticleGateway(ImageGateway imageGateway,
            NewsGateway newsGateway, QuotesGateway quotesGateway,
            SpaceshipsGateway spaceshipsGateway, WeatherGateway weatherGateway)
        {
            this.ImageGateway = imageGateway;
            this.NewsGateway = newsGateway;
            this.QuotesGateway = quotesGateway;
            this.SpaceshipsGateway = spaceshipsGateway;
            this.WeatherGateway = weatherGateway;
        }

        public ArticleEntity GetArticle()
        {
            throw new NotImplementedException();
        }
    }
}
