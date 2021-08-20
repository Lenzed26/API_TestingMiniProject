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
        public JArray Json_response { get; set; }
        //public DTO<BulkCharacterResponse> ListOfCharactersDTO { get; set; }        
        public int[] IdsSelected { get; set; }
        public string ListOfCharactersResponse { get; set; }

        public ListOfCharactersService()
        {
            CallManager = new CallManager();
            //ListOfCharactersDTO = new DTO<BulkCharacterResponse>();            
        }

        public async Task MakeRequestAsync(int[] ids)
        {
            IdsSelected = ids;
            ListOfCharactersResponse = await CallManager.MakeBulkCharacterRequestAsync(ids);
            Json_response = JArray.Parse(ListOfCharactersResponse);
            //ListOfCharactersDTO.DeserializeToListResponse(ListOfCharactersResponse);
        }
    }
}
