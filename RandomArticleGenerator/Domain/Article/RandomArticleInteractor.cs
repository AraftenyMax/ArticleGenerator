using RandomArticleGenerator.Domain.Template;
using RandomArticleGenerator.Gateways.Article;
using RandomArticleGenerator.OutputBoundary;
using RandomArticleGenerator.TemplateGenerator;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Domain.Article
{
    public class RandomArticleInteractor
    {
        IArticleGateway ArticleGateway;
        ITemplateGenerator TemplateGenerator;
        IOutputBoundary OutputBoundary;
        public RandomArticleInteractor(
            IArticleGateway articleGateway,
            ITemplateGenerator templateGenerator,
            IOutputBoundary outputBoundary)
        {
            this.ArticleGateway = articleGateway;
            this.TemplateGenerator = templateGenerator;
            this.OutputBoundary = outputBoundary;
        }
        public void Generate()
        {
            ArticleEntity article = ArticleGateway.GetArticle();
            GeneratedArticle generatedDoc = TemplateGenerator.GenerateArticle(article);
            OutputBoundary.Output(generatedDoc);
        }
    }
}
