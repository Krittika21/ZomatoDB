﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZomatoAPI.ViewModels
{
    public class RestaurantViewModel
    {
        public List<string> DishesName { get; set; }
        public string RestaurantName { get; set; }
        public List<int> LocationID { get; set; }
    }
}
