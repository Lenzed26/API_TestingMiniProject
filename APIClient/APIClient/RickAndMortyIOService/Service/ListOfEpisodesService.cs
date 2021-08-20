using APIClient.RickAndMortyIOService.DataHandling;
using APIClient.RickAndMortyIOService.HTTPManager;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.RickAndMortyIOService.Service
{
    class ListOfEpisodesService: IResponse
    {
        #region

        public CallManager CallManager { get; set; }

        public JObject Json_response { get; set; }

        public DTO<ListOfEpisodesService> ListOfEpisodesDTO { get; set; }

        public string EpisodeSelected { get; set; }

        public string EpisodeResponse { get; set; }

        public ListOfEpisodesService()
        {
            CallManager = new CallManager();
            ListOfEpisodesDTO = new DTO<ListOfEpisodesService>();
        }

        public async Task MakeBulkEpisodeRequest(string episode)
        {
            EpisodeSelected = episode;
            //make request
            EpisodeResponse = await CallManager.MakeBulkEpisodeRequestAsync();

            //parse JSON string into object
            Json_response = JObject.Parse(EpisodeResponse);

            //Serialize the DTO object
            ListOfEpisodesDTO.DeserializeResponse(EpisodeResponse);
        }

        #endregion
    }
}
