using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZomatoAPI.Models;
using ZomatoAPI.ViewModels;

namespace ZomatoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly ApiContext _context;

        public RestaurantsController(ApiContext context)
        {
            _context = context;
        }

        // GET: api/Restaurants
        [HttpGet]
        public IEnumerable<Restaurants> GetEachRestaurant()
        {
            return _context.Restaurants;
        }

        // GET: api/Restaurants/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRestaurants([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var restaurants = await _context.Restaurants.FindAsync(id);

            if (restaurants == null)
            {
                return NotFound();
            }

            return Ok(restaurants);
        }

        // PUT: api/Restaurants/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestaurants([FromRoute] int id, [FromBody] Restaurants restaurants)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != restaurants.ID)
            {
                return BadRequest();
            }

            _context.Entry(restaurants).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestaurantsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Locations
        [HttpPost]
        public async Task<IActionResult> PostLocations([FromBody] List<LocationViewModel> locationViews)
        {
            Country map;
            List<Location> Locations = new List<Location>();
            foreach (var item in locationViews)
            {
                map = await _context.Country.FirstAsync(x => x.ID == item.ID);
                Locations.Add( new Location
                {
                    City = new City
                    {
                        CityName = item.CityName
                    },
                    Country = map
                });
            }
            _context.Locations.AddRange(Locations);
            await _context.SaveChangesAsync();

            return Ok(locationViews);
        }

        // POST: api/Restaurants
        [HttpPost]
        public async Task<IActionResult> PostRestaurants([FromBody] List<RestaurantViewModel> restaurantViews)
        {
            List<Location> locate = new List<Location>();
            List<Restaurants> restaurants = new List<Restaurants>();

            foreach (var item in restaurantViews)
            {
                foreach (var elements in item.LocationID)
                {
                    locate.Add(await _context.Locations.FirstAsync(x => x.ID == elements));
                }
                List<Dishes> dish = new List<Dishes>();
                foreach (var elements in item.DishesName)
                {
                    dish.Add(new Dishes
                    {
                        DishesName = elements
                    });
                }
                restaurants.Add(new Restaurants
                {
                    RestaurantName = item.RestaurantName,
                    Location = locate,
                    Dishes = dish
                });
            }
            _context.Restaurants.AddRange(restaurants);
            await _context.SaveChangesAsync();

            return Ok(restaurantViews);
        }

        //POST: api/OrderedDetails
        [HttpPost]
        public async Task<IActionResult> PostOrderDetails([FromBody] List<OrderViewModel> orderView)
        {
            Restaurants map;
            List<Restaurants> restaurants = new List<Restaurants>();
            List<OrderDetails> orders = new List<OrderDetails>();

            foreach (var item in orderView)
            {
                foreach (var elements in item.RestaurantID)
                {
                    restaurants.Add(await _context.Restaurants.FirstAsync(x => x.ID == elements));
                }
                List<Users> user = new List<Users>();
                foreach (var elements in item.UserName)
                {
                    user.Add(new Users
                    {
                        Name = elements
                    });
                }
                orders.Add(new OrderDetails
                {
                    //User = user,
                    //Restaurant = restaurants
                });
            }
            //include sum of dishes' cost
            _context.Restaurants.AddRange(restaurants);
            await _context.SaveChangesAsync();

            return Ok(orderView);
        }

        // DELETE: api/Restaurants/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestaurants([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var restaurants = await _context.Restaurants.FindAsync(id);
            if (restaurants == null)
            {
                return NotFound();
            }

            _context.Restaurants.Remove(restaurants);
            await _context.SaveChangesAsync();

            return Ok(restaurants);
        }

        private bool RestaurantsExists(int id)
        {
            return _context.Restaurants.Any(e => e.ID == id);
        }
    }
}