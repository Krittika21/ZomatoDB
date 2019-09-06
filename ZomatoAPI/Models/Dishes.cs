using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.Models
{
    public class Dishes
    {
        public int ID { get; set; }
        public string DishesName { get; set; }

        public virtual Restaurants Restaurant { get; set; }
    }
}
