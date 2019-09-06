using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.Models
{
    public class Restaurants
    {
        public int ID { get; set; }
        public string RestaurantName { get; set; }        

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<Dishes> Dishes { get; set; }
    }
}
