using Microsoft.AspNetCore.Mvc;
using recipes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipes.Models;

namespace recipes.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RecipeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RecipeDetail(int id)
        {
            var findRecipe = _db.Recipe.Where(x => x.Id == id).ToList();
            return View(findRecipe);
        }
    }
}
