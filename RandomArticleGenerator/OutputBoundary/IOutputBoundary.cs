using RandomArticleGenerator.Domain.Template;

namespace RandomArticleGenerator.OutputBoundary
{
    public interface IOutputBoundary
    {
        public void Output(GeneratedArticle path);
    }
}
