using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.RickAndMortyIOService.DataHandling
{
    public class DTO<ResponseType> where ResponseType : IResponse, new()
    {
    }
}
