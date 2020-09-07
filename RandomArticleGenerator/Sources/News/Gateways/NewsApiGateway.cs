using RandomArticleGenerator.Domain.News;
using System;

namespace RandomArticleGenerator.Gateways.News
{
    class NewsApiGateway : INewsGateway
    {

        public NewsEntity GetNews(NewsSelectionCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public NewsEntity GetRandomNews()
        {
            throw new NotImplementedException();
        }
    }
}
