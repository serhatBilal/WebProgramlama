using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
   
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Recipes()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
