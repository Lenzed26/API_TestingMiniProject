using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIClient.RickAndMortyIOService.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;
        public int StatusCode { get; set; }

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakeBulkCharacterRequestAsync(int[] ids)
        {
            var list = String.Join(",", ids.Select(c => c.ToString()).ToArray());
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");

            request.Resource = $"character/{list}";

            var response = await _client.ExecuteAsync(request);        
            

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }
    }
}
