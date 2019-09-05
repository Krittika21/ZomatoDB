using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Locality { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
    }
}
