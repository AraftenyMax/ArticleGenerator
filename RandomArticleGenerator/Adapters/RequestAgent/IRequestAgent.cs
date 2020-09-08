using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Adapters.HttpAdapter
{
    public interface IRequestAgent
    {
        public Task<string> Get(string url);
    }
}
