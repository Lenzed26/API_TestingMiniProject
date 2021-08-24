using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebServer.Models
{

    public class Character
    {
        public Character()
        {
            Episodes = new HashSet<Episode>();    
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        //public Location Origin { get; set; }
        public Location Locations { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }        
    }

}
