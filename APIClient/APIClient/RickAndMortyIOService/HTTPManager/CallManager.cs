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
        

        public async Task<string> MakeEpisodeRequestAsync(string episode)
        {
            throw new NotImplementedException();
        }        

        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakeBulkCharacterRequestAsync(int[] ids)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");

            request.Resource = $"characters/{ids}";

            var response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }
    }
}
