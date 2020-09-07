using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Adapters.JsonAdapter
{
    interface IDatatypeSerializer
    {
        public T deserialize<T>(string rawData);
    }
}
