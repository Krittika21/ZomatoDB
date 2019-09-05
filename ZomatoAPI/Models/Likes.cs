using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.Models
{
    public class Likes
    {
        public int ID { get; set; }

        public virtual Reviews Reviews { get; set; }
        public virtual Users Users { get; set; }
    }
}
