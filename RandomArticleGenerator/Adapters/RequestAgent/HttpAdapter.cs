using log4net;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace RandomArticleGenerator.Adapters.HttpAdapter
{
    class HttpAdapter : IRequestAgent
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly HttpClient client = new HttpClient();
        public async Task<string> Get(string url)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            } catch(Exception ex)
            {
                _log.Error("Exception occurred in http request");
                _log.Error("Original exception:", ex);
                throw new Exception("Exception occurred in http request", ex);
            }
        }
    }
}
