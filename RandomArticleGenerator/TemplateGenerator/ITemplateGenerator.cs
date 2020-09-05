using RandomArticleGenerator.Domain.Article;
using RandomArticleGenerator.Domain.Template;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.TemplateGenerator
{
    public interface ITemplateGenerator
    {
        GeneratedArticle GenerateArticle(ArticleEntity article);
    }
}
