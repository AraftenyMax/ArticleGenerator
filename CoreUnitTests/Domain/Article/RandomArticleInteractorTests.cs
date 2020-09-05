using RandomArticleGenerator.Domain.Article;
using Moq;
using NUnit.Framework;
using RandomArticleGenerator.Domain.Template;
using RandomArticleGenerator.Gateways.Article;
using RandomArticleGenerator.OutputBoundary;
using RandomArticleGenerator.TemplateGenerator;

namespace RandomArticleGenerator.Domain.Article.Tests
{
    public class RandomArticleInteractorTests
    {
        ArticleEntity articleEntity;
        GeneratedArticle generatedTemplate;

        Mock<IArticleGateway> articleGatewayMock;
        Mock<ITemplateGenerator> templateGeneratorMock;
        Mock<IOutputBoundary> outputBoundaryMock;
        RandomArticleInteractor interactor;
        [SetUp]
        public void SetUp()
        {
            articleGatewayMock = new Mock<IArticleGateway>();
            templateGeneratorMock = new Mock<ITemplateGenerator>();
            outputBoundaryMock = new Mock<IOutputBoundary>();

            interactor = new RandomArticleInteractor(articleGatewayMock.Object,
                templateGeneratorMock.Object, outputBoundaryMock.Object);
        }

        [Test]
        public void SendsGeneratedArticle()
        {
            articleEntity = new ArticleEntity();
            generatedTemplate = new GeneratedArticle();
            GeneratedArticle anotherArticle = new GeneratedArticle();
            articleGatewayMock.Setup(gateway => gateway.GetArticle()).Returns(articleEntity);
            templateGeneratorMock.Setup(generator =>
                generator.GenerateArticle(It.IsAny<ArticleEntity>())).Returns(generatedTemplate);
            outputBoundaryMock.Setup(boundary => boundary.Output(It.IsAny<GeneratedArticle>()));

            interactor.Generate();
            outputBoundaryMock.Verify(mock => mock.Output(generatedTemplate), Times.Once());
        }
    }
}