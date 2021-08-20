using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using APIClient.RickAndMortyIOService.DataHandling;
using APIClient.RickAndMortyIOService.HTTPManager;

namespace APIClient.RickAndMortyIOService.Service
{
    class SingleCharacterService
    {
        //Properties
        public CallManager CallManager { get; set; }
        public JObject Json_response { get; set; }
        public DTO<SingleCharacterResponse> SingleCharactersDTO { get; set; }
        public int IdsSelected { get; set; }
        public string SingleCharactersResponse { get; set; }

        public SingleCharacterService()
        {
            CallManager = new CallManager();
            SingleCharactersDTO = new DTO<SingleCharacterResponse>();
        }

        public async Task MakeRequestAsync(int id)
        {
            IdsSelected = id;
            SingleCharactersResponse = await CallManager.MakeSingleCharacterRequestAsync(id);
            Json_response = JObject.Parse(SingleCharactersResponse);
            SingleCharactersDTO.DeserializeResponse(SingleCharactersResponse);
        }
    }
}
