using Microsoft.AspNetCore.Mvc;
using recipes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using recipes.Models;

namespace recipes.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AboutController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var degerler = _db.About.ToList();
            return View(degerler);
        }
    }
}
