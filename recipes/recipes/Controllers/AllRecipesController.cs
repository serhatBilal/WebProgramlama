using Microsoft.AspNetCore.Mvc;
using recipes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Controllers
{
    public class AllRecipesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AllRecipesController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var recipes = _db.Recipe.ToList();
            return View(recipes);
        }
      
    }
}
