using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sports_ORM.Models;
using Microsoft.EntityFrameworkCore;

namespace Sports_ORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context context;

        public HomeController(Context DBContext)
        {
            context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = context.Leagues
                .Where(l => l.Sport.Contains("Baseball"));
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.WomensLeagues = context.Leagues.Where(l=>l.Name.Contains("Women")).ToList();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}