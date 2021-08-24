using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebServer.Models
{

    public class Location
    {
        public Location()
        {
            Residents = new HashSet<Character>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Dimension { get; set; }
        public virtual ICollection<Character> Residents { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
        
    }

}
