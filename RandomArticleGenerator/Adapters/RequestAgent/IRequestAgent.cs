using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Adapters.HttpAdapter
{
    interface IRequestAgent
    {
        public string get(string url);
    }
}
