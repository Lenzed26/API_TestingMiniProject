﻿using System.Threading.Tasks;
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

        public async Task<string> MakeSingleEpisodeRequestAsync(string episode)
        {
            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");

            request.Resource = $"episode/{episode.ToLower().Replace(" ", "")}";

            var response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<string> MakeBulkEpisodeRequestAsync(string episode)
        {
            var request = new RestRequest(Method.GET);

            request.AddHeader("Content-Type", "application/json");

            request.Resource = $"{episode}";

            var response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<string> MakeBulkCharacterRequestAsync()
        {            
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");

            request.Resource = $"character";

            var response = await _client.ExecuteAsync(request);        
            

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }

        public async Task<IRestResponse> MakeSingleLocationRequestAsync(int id)
        {
            //Set up the Request
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");
            //Define request resource path
            request.Resource = $"location/{id}";
            //Make Request and Return the Response 
            return await _client.ExecuteAsync(request);
        }


        public async Task<string> MakeSingleCharacterRequestAsync(int id)
        {
            var request = new RestRequest();
            request.AddHeader("Content-Type", "application/json");

            request.Resource = $"character/{id}";

            var response = await _client.ExecuteAsync(request);

            StatusCode = (int)response.StatusCode;
            return response.Content;
        }


    }
}
