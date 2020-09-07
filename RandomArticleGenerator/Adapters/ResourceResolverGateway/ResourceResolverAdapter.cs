using RandomArticleGenerator.Adapters.HttpAdapter;
using RandomArticleGenerator.Adapters.JsonAdapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Adapters.OuterGatewayAdapter
{
    class ResourceResolverAdapter : IResourceResolver
    {
        private IRequestAgent agent;
        private IDatatypeSerializer serializer;
        public ResourceResolverAdapter(IRequestAgent requestAgentAdapter,
            IDatatypeSerializer datatypeSerializer)
        {
            agent = requestAgentAdapter;
            serializer = datatypeSerializer;
        }

        public T RetrieveData<T>(string path)
        {
            throw new NotImplementedException();
        }
    }
}
