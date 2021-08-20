using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace APIClient.RickAndMortyIOService.DataHandling
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
        public ResponseType Response { get; set; }

        public void DeserializeToListResponse(string response)
        {
            Response = JsonConvert.DeserializeObject<ResponseType>(response);
        }

    }
}
