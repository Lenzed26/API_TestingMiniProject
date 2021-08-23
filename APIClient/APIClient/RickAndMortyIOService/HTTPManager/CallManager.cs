using System.Threading.Tasks;
using RestSharp;

namespace APIClient.RickAndMortyIOService.HTTPManager
{
    public class CallManager
    {
        private readonly IRestClient _client;
        private readonly RestRequest request;
        public int StatusCode { get; set; }

        public CallManager()
        {
            request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakeSingleEpisodeRequestAsync(string episode)
        {
            var request = new RestRequest(Method.GET);

            request.Resource = $"episode/{episode.ToLower().Replace(" ", "")}";
            var response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<string> MakeBulkEpisodeRequestAsync()
        {
            var request = new RestRequest(Method.GET);

            request.Resource = $"episode";

            var response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<string> MakeBulkCharacterRequestAsync()
        {            
            request.Resource = $"character";
            var response = await _client.ExecuteAsync(request);        
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<IRestResponse> MakeSingleLocationRequestAsync(int id)
        {

            //Define request resource path
            request.Resource = $"location/{id}";
            //Make Request and Return the Response 
            return await _client.ExecuteAsync(request);
        }


        public async Task<string> MakeSingleCharacterRequestAsync(int id)
        {
            request.Resource = $"character/{id}";
            var response = await _client.ExecuteAsync(request);
            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

    }
}
