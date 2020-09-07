using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Adapters.OuterGatewayAdapter
{
    interface IResourceResolver
    {
        public T RetrieveData<T>(string path);
    }
}
