using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using recipes.Data;
using recipes.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Controllers
{
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            var recipes = _db.Category.ToList();
            return View(recipes);
        }
    

    }
}
