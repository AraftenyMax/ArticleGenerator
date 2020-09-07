using RandomArticleGenerator.Domain.News;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Gateways.News
{
    public interface INewsGateway
    {
        NewsEntity GetNews(NewsSelectionCriteria criteria);
        NewsEntity GetRandomNews();
    }
}
