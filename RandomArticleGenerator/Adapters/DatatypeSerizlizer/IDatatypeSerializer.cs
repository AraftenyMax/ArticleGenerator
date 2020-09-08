using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Adapters.JsonAdapter
{
    public interface IDatatypeSerializer
    {
        public T Deserialize<T>(string rawData);
    }
}
