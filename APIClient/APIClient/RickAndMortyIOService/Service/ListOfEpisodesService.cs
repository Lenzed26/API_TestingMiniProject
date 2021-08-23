﻿using APIClient.RickAndMortyIOService.DataHandling;
using APIClient.RickAndMortyIOService.HTTPManager;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace APIClient.RickAndMortyIOService.Service
{
    class ListOfEpisodesService: IResponse
    {
        #region

        public CallManager CallManager { get; set; }

        public JObject Json_response { get; set; }

        public DTO<BulkEpisodeResponse> ListOfEpisodesDTO { get; set; }

        public string EpisodeSelected { get; set; }

        public string EpisodeResponse { get; set; }

        public ListOfEpisodesService()
        {
            CallManager = new CallManager();
            ListOfEpisodesDTO = new DTO<BulkEpisodeResponse>();
        }

        public async Task MakeBulkEpisodeRequest(string episode)
        {
            EpisodeSelected = episode;
            //make request
            EpisodeResponse = await CallManager.MakeBulkEpisodeRequestAsync(episode);

            //parse JSON string into object
            Json_response = JObject.Parse(EpisodeResponse);

            //Serialize the DTO object
            ListOfEpisodesDTO.DeserializeResponse(EpisodeResponse);
        }

        #endregion
    }
}
