using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using RandomnPassword.Models;
 
namespace RandomnPassword.Controllers
{
    
    public class HomeController:Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {

            return RedirectToAction("success");

        }

        [HttpPost("randomngenerate")]
        public IActionResult randomngenerate()
        {
            return RedirectToAction("success");
        }

        [HttpGet("success")]
        public ViewResult success()
        {
            //Generate randomn string
            Random rnd = new Random();
            HttpContext.Session.SetString("randstring",randomngen.GenerateString(13,rnd));
            // set viewbag to see it in views
            ViewBag.randomnstring = HttpContext.Session.GetString("randstring");
            //set intial count as 1
            
            int? IntVariable = HttpContext.Session.GetInt32("randCount");
            if(IntVariable== null)
            {
                HttpContext.Session.SetInt32("randCount", 1);
            }
            else
            {
                HttpContext.Session.SetInt32("randCount", (int)IntVariable+1);

            }

            int? intvar = HttpContext.Session.GetInt32("randCount");

            //set viewbag to monitor count
            ViewBag.count = intvar;
            
            return View();

        }


       

    }
}
