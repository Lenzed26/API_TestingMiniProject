using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.RickAndMortyIOService.DataHandling
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
    }
}
