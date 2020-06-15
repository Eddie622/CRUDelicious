using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes
                .OrderByDescending(dish => dish.DishId).ToList();

            return View(AllDishes);
        }

        public IActionResult AddDish()
        {
            return View();
        }

        [HttpGet("DisplayDish/{dishId}")]
        public IActionResult DisplayDish(int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(ThisDish);
        }

        [HttpPost]
        public IActionResult CreateDish(Dish dish)
        {
            if (ModelState.IsValid)
            {   
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return Redirect("Index");
            }
            else
            {
                return View("AddDish");
            }
        }

        [HttpPost]
        [Route("{dishId}/Delete")]
        public IActionResult DeleteDish(int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            dbContext.Dishes.Remove(ThisDish);
            dbContext.SaveChanges();
            return Redirect("../../");
        }

        [HttpGet]
        [Route("{dishId}/Edit")]
        public IActionResult EditDish(int dishId)
        {
            Dish ThisDish = dbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(ThisDish);
        }

        [HttpPost]
        public IActionResult ProcessEdit(Dish dish)
        {
            if (ModelState.IsValid)
            {   
                Console.WriteLine($"\n\n{dish.DishId}\n\n");
                Dish ThisDish = dbContext.Dishes.FirstOrDefault(dbDish => dbDish.DishId == dish.DishId);
                ThisDish.Name = dish.Name;
                ThisDish.Description = dish.Description;
                ThisDish.Calories = dish.Calories;
                ThisDish.Chef = dish.Chef;
                ThisDish.Tastiness = dish.Tastiness;
                dbContext.SaveChanges();
                return Redirect("Index");
            }
            else
            {
                return View("EditDish");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
