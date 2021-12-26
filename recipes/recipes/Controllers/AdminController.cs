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
            var urecipe = _db.Recipe.Find(r.Id);
            urecipe.Details = r.Details;
            urecipe.Name = r.Name;
            urecipe.Materials = r.Materials;
            urecipe.FoodImage = r.FoodImage;
            urecipe.CategoryId = r.CategoryId;
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult GetComment()
        {
            var comment = _db.Comment.ToList();
            return View(comment);
        }

        public IActionResult DeleteComment(int id)
        {
            var delComment = _db.Comment.Find(id);
            _db.Comment.Remove(delComment);
            _db.SaveChanges();
            return RedirectToAction("GetComment");
        }
        public IActionResult CallComment(int id)
        {
            var cm = _db.Comment.Find(id);
            return View("CallComment", cm);
        }
        public IActionResult UpdateComment(Comment c)
        {
            var cmnt = _db.Comment.Find(c.Id);
            cmnt.Name = c.Name;
            cmnt.Email = c.Email;
            cmnt.UserComment = c.UserComment;
            _db.SaveChanges();
            return RedirectToAction("GetComment");

        }

        [HttpGet]
        public IActionResult NewCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewCategory(Category c)
        {
            _db.Category.Add(c);
            _db.SaveChanges();
            return RedirectToAction("GetCategory");
        }

        public IActionResult GetCategory()
        {
            var category = _db.Category.ToList();
            return View(category);
        }

        public IActionResult DeleteCategory(int id)
        {
            var delCategory = _db.Category.Find(id);
            _db.Category.Remove(delCategory);
            _db.SaveChanges();
            return RedirectToAction("GetCategory");
        }
        public IActionResult CallCategory(int id)
        {
            var category = _db.Category.Find(id);
            return View("CallCategory", category);
        }
        public IActionResult UpdateCategory(Category c)
        {
            var category = _db.Category.Find(c.Id);
            category.Name = c.Name;
            category.ImageUrl = c.ImageUrl;
            _db.SaveChanges();
            return RedirectToAction("GetCategory");

        }

        public IActionResult GetAbout()
        {
            var about = _db.About.ToList();
            return View(about);
        }

        public IActionResult CallAbout(int id)
        {
            var about = _db.About.Find(id);
            return View("CallAbout", about);
        }
        public IActionResult UpdateAbout(About a)
        {
            var about = _db.About.Find(a.Id);
            about.Title = a.Title;
            about.ImageUrl = a.ImageUrl;
            about.Detail = a.Detail;
            _db.SaveChanges();
            return RedirectToAction("GetAbout");

        }

    }
}