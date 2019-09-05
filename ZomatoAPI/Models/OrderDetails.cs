using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Restaurants Restaurant { get; set; }
        public virtual Users User { get; set; }
    }
}
