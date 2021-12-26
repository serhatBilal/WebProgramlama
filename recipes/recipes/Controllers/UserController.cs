using Microsoft.AspNetCore.Mvc;
using recipes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace recipes.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
    }
}
