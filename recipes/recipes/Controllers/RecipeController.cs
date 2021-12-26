using Microsoft.AspNetCore.Mvc;
using recipes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipes.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace recipes.Controllers
{
    public class RecipeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public RecipeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int id)
        {
            var find = _db.Recipe.Where(x => x.CategoryId == id).ToList();
            return View(find);
        }
        RecipeComment rc = new RecipeComment();
        public IActionResult RecipeDetail(int id)
        {
            rc.Value1 = _db.Recipe.Where(x => x.Id == id).ToList();
            rc.Value2 = _db.Comment.Where(x => x.RecipeId == id).ToList();
            ViewBag.value = id;
            return View(rc);
        }

        public int RecipeId { get; set; }

        [HttpPost]
        public IActionResult AddComment(Comment cm)
        {
            
            Comment comment = new Comment();
            comment.UserComment = cm.UserComment;
            comment.Name = cm.Name;
            comment.Email = cm.Email;
            comment.Date = cm.Date;
            comment.RecipeId =cm.RecipeId;
            _db.Comment.Add(comment);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult AddComment(int id)
        {
            
            return View();
        }
     

    }
}
