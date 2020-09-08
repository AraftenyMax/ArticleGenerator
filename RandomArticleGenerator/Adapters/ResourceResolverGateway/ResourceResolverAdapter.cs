using RandomArticleGenerator.Adapters.HttpAdapter;
using RandomArticleGenerator.Adapters.JsonAdapter;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Adapters.OuterGatewayAdapter
{
    public class ResourceResolverAdapter : IResourceResolver
    {
        private IRequestAgent agent;
        private IDatatypeSerializer serializer;
        public ResourceResolverAdapter(IRequestAgent requestAgentAdapter,
            IDatatypeSerializer datatypeSerializer)
        {
            agent = requestAgentAdapter;
            serializer = datatypeSerializer;
        }

        public async Task<T> RetrieveData<T>(string path)
        {
            string rawData = await agent.Get(path);
            T data = serializer.Deserialize<T>(rawData);
            return data;
        }
    }
}
