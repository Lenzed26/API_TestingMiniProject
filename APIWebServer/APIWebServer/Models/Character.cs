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
            Episode = new HashSet<Episode>();    
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        //public Location Origin { get; set; }
        public Location Location { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Episode> Episode { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }        
    }

}
