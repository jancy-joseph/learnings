using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ValidateForm.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace ValidateForm.Controllers
{
    public class HomeController:Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            Console.WriteLine("Hello");
            return View();

        }
        [HttpPost("registerUser")]
        public IActionResult registerUser(User usr)
        {
            Console.WriteLine("Heree");
            Console.WriteLine($"{usr.FirstName} {usr.LastName}{usr.Email}{usr.Age}{usr.Password}{usr.ConfirmPW}");

            if(ModelState.IsValid)
            {
                return RedirectToAction("success",usr);
            }
            else
            {
                Console.WriteLine("Else part");
                Console.WriteLine($"{usr.FirstName} {usr.LastName}{usr.Email}{usr.Age}{usr.Password}{usr.ConfirmPW}");
                return View("Index",usr);
            }
        }

        [HttpGet("success")]
        public IActionResult success(User usr)
        {
            var fname = usr.FullName;
            Dojo d1 = new Dojo(fname,new List<string>(){"seattle","chicago","san jose"},new List<string>(){"C#","Python","Javascript"});
            Console.WriteLine("d1 full name:",d1.FullName);
            DojoUserWrapper duw = new DojoUserWrapper(usr,d1);
            return View(duw);
        }

        [HttpPost("dojoRegister")]
        public IActionResult dojoRegister(DojoUserWrapper duw)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("dojoSuccess",duw);
            }
            else
            {
                return RedirectToAction("success",duw);
            }
        }

        [HttpGet("dojoSuccess")]
        public IActionResult dojoSuccess(DojoUserWrapper duw)
        {
            return View(duw);
        }
        



    }
}