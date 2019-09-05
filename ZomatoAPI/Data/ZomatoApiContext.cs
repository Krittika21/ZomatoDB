using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace ZomatoAPI.Models
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            : base(options)
        {
        }

        public DbSet<ZomatoAPI.Models.Restaurants> Restaurants { get; set; }
        public DbSet<ZomatoAPI.Models.City> City { get; set; }
        public DbSet<ZomatoAPI.Models.Country> Country { get; set; }
        public DbSet<ZomatoAPI.Models.Dishes> Dishes { get; set; }
        public DbSet<ZomatoAPI.Models.DishesOrdered> OrderedDishes { get; set; }
        public DbSet<ZomatoAPI.Models.Likes> Likes { get; set; }
        public DbSet<ZomatoAPI.Models.Location> Locations { get; set; }
        public DbSet<ZomatoAPI.Models.OrderDetails> OrderDetails { get; set; }
        public DbSet<ZomatoAPI.Models.Rating> Ratings { get; set; }
        public DbSet<ZomatoAPI.Models.Reviews> Reviews { get; set; }
        public DbSet<ZomatoAPI.Models.UserFollow> Follows { get; set; }
        public DbSet<ZomatoAPI.Models.Users> Users { get; set; }
    }
}
