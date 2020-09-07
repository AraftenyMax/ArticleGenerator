using RandomArticleGenerator.Domain.Article;

namespace RandomArticleGenerator.Gateways.Article
{
    public interface IArticleGateway
    {
        public ArticleEntity GetArticle();
    }
}
