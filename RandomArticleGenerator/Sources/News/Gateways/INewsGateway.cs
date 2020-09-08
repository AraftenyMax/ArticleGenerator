using RandomArticleGenerator.Domain.News;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Gateways.News
{
    public interface INewsGateway
    {
        Task<NewsEntity> GetNews(NewsSelectionCriteria criteria);
        Task<NewsEntity> GetRandomNews();
    }
}
