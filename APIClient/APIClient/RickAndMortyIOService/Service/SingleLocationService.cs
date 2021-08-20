using System;
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
    class SingleLocationService
    {
        #region Properties
        public CallManager CallManager { get; set; }
        public JObject Json_response { get; set; }
        public int StatusCode { get; set; }
        public DTO<LocationResponse> LocationsDTO { get; set; }
        public int LocationSelected { get; set; }
        public RestSharp.IRestResponse LocationResponse { get; set; }

        #endregion

        public SingleLocationService()
        {
            CallManager = new CallManager();
            LocationsDTO = new DTO<LocationResponse>();
        }

        public async Task MakeRequestAsync(int location)
        {
            LocationSelected = location;
            //Make Request
            LocationResponse = await CallManager.MakeSingleLocationRequestAsync(LocationSelected);
            //Parse JSON String into a JObject
            Json_response = JObject.Parse(LocationResponse.Content);
            //Get Status Code From response
            StatusCode = Convert.ToInt32(LocationResponse.StatusCode);
            //Use DTO to convert JSON string to an object tree
            LocationsDTO.DeserializeResponse(LocationResponse.Content);
        }
        public List<string> GetListOfResidentsFromLocation()
        {
            List<string> listOfResidents = new List<string>();
            foreach (var resident in LocationsDTO.Response.residents)
            {
                listOfResidents.Add(resident);
            }
            return listOfResidents;
        }
    }
}
