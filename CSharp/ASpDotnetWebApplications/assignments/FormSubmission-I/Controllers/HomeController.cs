using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission_I.Models;

namespace FormSubmission_I.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Success(User user1)
        {
            if(ModelState.IsValid)
            {
               
                // do somethng!  maybe insert into db?  then we will redirect
                return View(user1);
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
