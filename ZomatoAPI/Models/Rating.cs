using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public decimal AverageRating { get; set; }

        public virtual Restaurants Restaurant { get; set; }
        public virtual Users User { get; set; }
    }
}
