using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Belt.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
namespace Belt.Controllers
{
    public class HomeController: Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext= context;
        }
        
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(LogRegWrapper submission)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Username== submission.RegUser.Username))
                {
                    ModelState.AddModelError("RegUser.Username", "A user exists with this Username");
                    return View("Index", submission);
                }
                PasswordHasher<User> pwhash = new PasswordHasher<User>();
                submission.RegUser.Password = pwhash.HashPassword(submission.RegUser, submission.RegUser.Password);
                dbContext.Add(submission.RegUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("UserId", submission.RegUser.UserId);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }

        }

        [HttpPost("login")]
        public IActionResult Login(LogRegWrapper submission)
        {
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u => u.Username == submission.LogUser.LoginUsername);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LogUser.LoginUsername", "Invalid Username");
                    return View("Index", submission);
                }

                PasswordHasher<LoginUser> pwhash = new PasswordHasher<LoginUser>();
                var result = pwhash.VerifyHashedPassword(submission.LogUser, userInDb.Password, submission.LogUser.LoginPassword);

                if(result == 0) 
                {
                    ModelState.AddModelError("LogUser.LoginPassword", "Invalid Password");
                    return View("Index", submission);
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }

            //  DashboardWrapper vMod = new DashboardWrapper();

            //  vMod.LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)UserId);
            // vMod.AllHobbys= dbContext.Hobbys
            //     .Include(t => t.Name)
            //     .Include(t=>t.Enthusiasts.Count())
            //     .ToList();
            
            // return View(vMod);
            return View();
        }
        
    }
}