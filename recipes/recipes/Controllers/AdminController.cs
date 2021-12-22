using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipes.Models;
using recipes.Data;

namespace recipes.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var values = _db.Recipe.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult NewRecipe()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewRecipe(Recipe r)
        {
            _db.Recipe.Add(r);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteRecipe(int id)
        {
            var dr = _db.Recipe.Find(id);
            _db.Recipe.Remove(dr);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetRecipe(int id)
        {
            var rcp = _db.Recipe.Find(id);
            return View("GetRecipe", rcp);
        }
        public IActionResult UpdateRecipe(Recipe r)
        {
            var urecipe  = _db.Recipe.Find(r.Id);
            urecipe.Details = r.Details;
            urecipe.Name = r.Name;
            urecipe.Materials = r.Materials;
            urecipe.FoodImage = r.FoodImage;
            urecipe.CategoryId = r.CategoryId;
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
    }
}
