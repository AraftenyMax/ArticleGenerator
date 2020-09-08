using log4net;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.Json;

namespace RandomArticleGenerator.Adapters.JsonAdapter
{
    public class JsonAppSerializer : IDatatypeSerializer
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public T Deserialize<T>(string rawData)
        {
            try
            {
                T item = JsonSerializer.Deserialize<T>(rawData);
                return item;
            } catch (Exception ex)
            {
                _log.Error("Exception occurred while parsing json response");
                _log.Error("Original message:", ex);
                throw new Exception("Exception occurred while parsing json response", ex);
            }
        }
    }
}
