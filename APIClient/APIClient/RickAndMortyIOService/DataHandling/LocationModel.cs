using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIClient.RickAndMortyIOService.DataHandling
{

    public class LocationResponse : IResponse
    {
        public Info info { get; set; }
        public LocationDetails[] LocationDetails { get; set; }
    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string next { get; set; }
        public object prev { get; set; }
    }

    public class LocationDetails
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string dimension { get; set; }
        public string[] residents { get; set; }
        public string url { get; set; }
        public DateTime created { get; set; }
    }

}
