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
            var recipes = _db.Recipe.ToList();
            return View(recipes);
        }
        RecipeComment rc = new RecipeComment();
        public IActionResult RecipeDetail(int id)
        {
            rc.Value1 = _db.Recipe.Where(x => x.Id == id).ToList();
            rc.Value2 = _db.Comment.Where(x => x.RecipeId == id).ToList();

            return View(rc);
        }

    }
}
