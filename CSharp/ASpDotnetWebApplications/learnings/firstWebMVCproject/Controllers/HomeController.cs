using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstWebMVCproject.Models;

namespace firstWebMVCproject.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View("index");
        }

        [HttpPost("CreateNewUser")]
        public IActionResult user(User user1){
            if(ModelState.IsValid)
            {
                Console.WriteLine(user1.FirstName);
                // do somethng!  maybe insert into db?  then we will redirect
                return View("user",user1);
             }
            else
            {
                // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                return  RedirectToAction("index");
            }

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
