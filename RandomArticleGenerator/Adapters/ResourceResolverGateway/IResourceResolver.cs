using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Adapters.OuterGatewayAdapter
{
    interface IResourceResolver
    {
        public Task<T> RetrieveData<T>(string path);
    }
}
