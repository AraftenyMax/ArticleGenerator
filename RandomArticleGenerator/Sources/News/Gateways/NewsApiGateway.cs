using RandomArticleGenerator.Domain.News;
using System;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.News
{
    class NewsApiGateway : INewsGateway
    {

        public Task<NewsEntity> GetNews(NewsSelectionCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Task<NewsEntity> GetRandomNews()
        {
            throw new NotImplementedException();
        }
    }
}
