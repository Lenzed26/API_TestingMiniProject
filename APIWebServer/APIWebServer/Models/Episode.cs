using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebServer.Models
{

    public class Episode
    {
        public Episode()
        {
            Characters = new HashSet<Character>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Air_date { get; set; }
        public string episode { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }

        
    }

}
