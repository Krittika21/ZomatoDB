using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.ViewModels
{
    public class OrderViewModel
    {
       // public List<int> UserID { get; set; }
        public List<int> RestaurantID { get; set; }
        public List<string> UserName { get; set; }
        public List<string> DishesName { get; set; }
    }
}
