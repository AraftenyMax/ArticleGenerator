using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Adapters.JsonAdapter
{
    class JsonSerializer : IDatatypeSerializer
    {
        public T deserialize<T>(string rawData)
        {
            throw new NotImplementedException();
        }
    }
}
