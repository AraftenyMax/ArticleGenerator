using CoreUnitTests.Adapters.ResourceResolverGateway;
using Moq;
using NUnit.Framework;
using RandomArticleGenerator.Adapters.HttpAdapter;
using RandomArticleGenerator.Adapters.JsonAdapter;
using RandomArticleGenerator.Adapters.OuterGatewayAdapter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreUnitTests.Adapters
{
    class ResourceResolverGatewayTests
    {
        ResourceResolverAdapter resolver;
        Mock<IRequestAgent> requestAgent;
        Mock<IDatatypeSerializer> serializer;
        [SetUp]
        public void SetUp()
        {
            requestAgent = new Mock<IRequestAgent>();
            serializer = new Mock<IDatatypeSerializer>();

            resolver = new ResourceResolverAdapter(requestAgent.Object, serializer.Object);
        }

        [Test]
        public async Task NormalExecutionFlow()
        {
            string pathToResource = "path";
            string validResponse = "{\"A\": \"ValidResponse\"}";
            SampleModel expectedModel = new SampleModel { A = "ValidResponse" };

            requestAgent.Setup(mock => mock.Get(It.IsAny<string>())).ReturnsAsync(validResponse);
            serializer.Setup(mock => mock.Deserialize<SampleModel>(It.IsAny<string>())).Returns(expectedModel);
            SampleModel actualModel = await resolver.RetrieveData<SampleModel>(pathToResource);

            Assert.AreEqual(expectedModel, actualModel);
        }

        [Test]
        public void DatatypeSerializerThrowsException()
        {
            string pathToResource = "anotherPath";
            string invalidResponse = "{\"A\": \"ValidResponse\"";
            string errorMessage = "Exception occurred while parsing json response";

            requestAgent.Setup(mock => mock.Get(It.IsAny<string>())).ReturnsAsync(invalidResponse);
            serializer.Setup(mock => mock.Deserialize<SampleModel>
                (It.IsAny<string>())).Throws(new Exception(errorMessage));

            Assert.ThrowsAsync(Is.TypeOf<Exception>().And.Message.EqualTo(errorMessage)
                , async delegate { await resolver.RetrieveData<SampleModel>(pathToResource); });
        }

        [Test]
        public async Task RequestAgentThrowsException()
        {
            string pathToResource = "anotherOnePath";
            string errorMessage = "Exception occurred in http request";

            requestAgent.Setup(mock => mock.Get(It.IsAny<string>())).Throws(new Exception(errorMessage));

            Assert.ThrowsAsync(Is.TypeOf<Exception>().And.Message.EqualTo(errorMessage),
                async delegate { await resolver.RetrieveData<SampleModel>(pathToResource); });
        }
    }
}
