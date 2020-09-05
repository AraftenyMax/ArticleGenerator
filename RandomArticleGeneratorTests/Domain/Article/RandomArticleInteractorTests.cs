using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomArticleGenerator.Domain.Article;
using RandomArticleGenerator.Domain.Image;
using RandomArticleGenerator.Domain.News;
using RandomArticleGenerator.Domain.Quote;
using RandomArticleGenerator.Domain.Spaceships;
using RandomArticleGenerator.Domain.Weather;
using RandomArticleGenerator.Gateways.Article;
using RandomArticleGenerator.OutputBoundary;
using RandomArticleGenerator.TemplateGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Domain.Article.Tests
{
    [TestFixture]
    public class RandomArticleInteractorTests
    {
        ImageEntity imageEntity;
        NewsEntity newsEntity;
        QuoteEntity quoteEntity;
        SpaceshipEntity spaceshipEntity;
        WeatherEntity weatherEntity;
        ArticleEntity articleEntity;
        ArticleEntity expectedArticle;

        IArticleGateway articleGateway;
        ITemplateGenerator templateGenerator;
        IOutputBoundary outputBoundary;

        [TestMethod()]
        public void RandomArticleInteractorTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GenerateTest()
        {
            Assert.Fail();
        }
    }
}