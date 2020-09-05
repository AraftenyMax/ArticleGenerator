using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Domain.Article
{
    public abstract class ArticleItemEntity
    {
        public string NameInTemplate { get; set; }
        public abstract string GetEntityTemplate();
    }
}
