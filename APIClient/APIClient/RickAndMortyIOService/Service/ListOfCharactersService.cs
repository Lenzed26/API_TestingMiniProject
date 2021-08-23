using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using APIClient.RickAndMortyIOService.DataHandling;
using APIClient.RickAndMortyIOService.HTTPManager;
using RestSharp;

namespace APIClient.RickAndMortyIOService.Service
{
    class ListOfCharactersService
    {
        //Properties
        public CallManager CallManager { get; set; }
        public JObject Json_response { get; set; }
        public DTO<BulkCharacterResponse> ListOfCharactersDTO { get; set; }         
        public string ListOfCharactersResponse { get; set; }

        public ListOfCharactersService()
        {
            CallManager = new CallManager();
            ListOfCharactersDTO = new DTO<BulkCharacterResponse>();
        }

        public async Task MakeRequestAsync()
        {
            ListOfCharactersResponse = await CallManager.MakeBulkCharacterRequestAsync();
            Json_response = JObject.Parse(ListOfCharactersResponse);
            ListOfCharactersDTO.DeserializeResponse(ListOfCharactersResponse);
        }
    }
}
