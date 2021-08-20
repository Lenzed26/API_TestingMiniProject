﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using APIClient.RickAndMortyIOService.DataHandling;
using APIClient.RickAndMortyIOService.HTTPManager;


namespace APIClient.RickAndMortyIOService.Service
{
    class ListOfCharactersService
    {
        //Properties
        public CallManager CallManager { get; set; }
        public JObject Json_response { get; set; }
        public DTO<CharacterResponse> ListOfCharactersDTO { get; set; }
        public int[] IdsSelected { get; set; }
        public string ListOfCharactersResponse { get; set; }

        public ListOfCharactersService()
        {
            CallManager = new CallManager();
            ListOfCharactersDTO = new DTO<CharacterResponse>();
        }

        public async Task MakeRequestAsync(int[] ids)
        {
            IdsSelected = ids;
            ListOfCharactersResponse = await CallManager.MakeBulkCharacterRequestAsync(ids);
            Json_response = JObject.Parse(ListOfCharactersResponse);
            ListOfCharactersDTO.DeserializeResponse(ListOfCharactersResponse);
        }
    }
}
