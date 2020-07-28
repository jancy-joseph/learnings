using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using newBelt.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace newbelt.Controllers
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
            HttpContext.Session.SetInt32("flag",0);

            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(LogRegWrapper submission)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == submission.RegUser.Email))
                {
                    ModelState.AddModelError("RegUser.Email", "A user exists with this email address");
                    return View("Index", submission);
                }
                PasswordHasher<User> pwhash = new PasswordHasher<User>();
                submission.RegUser.Password = pwhash.HashPassword(submission.RegUser, submission.RegUser.Password);
                dbContext.Add(submission.RegUser);
                dbContext.SaveChanges();

                HttpContext.Session.SetInt32("UserId", submission.RegUser.UserId);
                return RedirectToAction("dashboard");
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
                User userInDb = dbContext.Users.FirstOrDefault(u => u.Email == submission.LogUser.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LogUser.LoginEmail", "Invalid Email/Password");
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
                return RedirectToAction("dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult dashboard()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;
            if(UserId == 0)
            {
                return RedirectToAction("Index");
            } 

            DashboardWrapper vMod = new DashboardWrapper();

            vMod.LoggedUser = dbContext.Users
            .Include(u=>u.ActivitiesOfuser)
            .ThenInclude(a=>a.Activity)
            .FirstOrDefault(u => u.UserId == (int)UserId);

            vMod.AllActivities= dbContext.Activities
            .Include(t=>t.UsersInActivities)
            .ThenInclude(u=>u.User)
            .OrderByDescending(t=>t.CreatedAt)
            .Where(t=>t.ActivityDate > DateTime.Now)
            .ToList();
            ViewBag.myflag = HttpContext.Session.GetInt32("flag");

             return View(vMod);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("addNewActivity")]
        public IActionResult addNewActivity()
        {
            int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }
            NewActivityWrapper vMod = new NewActivityWrapper();
            vMod.LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)UserId);
            return View(vMod);

        }
           
        [HttpGet("addNewActivityError")]
        public IActionResult addNewActivityError(NewActivityWrapper submission)
        {
             int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }
            submission.LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)UserId);
            return View("addNewActivity",submission);

        }


        [HttpPost("createNewActivity")]
         public IActionResult createNewActivity(NewActivityWrapper submission)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }
             submission.newActivity.UserId = (int)UserId;

            if(ModelState.IsValid)
            {
                dbContext.Activities.Add(submission.newActivity);
                dbContext.SaveChanges();

                return RedirectToAction("showActivity",new{ActivityId =submission.newActivity.ActivityId});

            }
            else
            {
                submission.LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)UserId);

                return View("addNewActivity",submission);
               // return RedirectToAction("addNewActivityError",submission);
            }
        }

        

        [HttpGet("showActivity/{ActivityId}")]
        public IActionResult showActivity(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }
            ShowActivityWrapper vMod = new ShowActivityWrapper();
                
                 vMod.newActivity =dbContext.Activities
                 .Include(a=>a.UsersInActivities)
                 .ThenInclude(u=>u.User)
                 .FirstOrDefault(a=>a.ActivityId== ActivityId);
                vMod.LoggedUser=dbContext.Users
                .FirstOrDefault(u => u.UserId == (int)UserId);
            return View(vMod);
        }

        [HttpPost("deleteActivity/{ActivityId}")]
        public IActionResult deleteActivity(int ActivityId)
        {
             int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }

            Activity ToDelete = dbContext.Activities.FirstOrDefault(x=>x.ActivityId == ActivityId);
            dbContext.Remove(ToDelete);
            dbContext.SaveChanges();
            return RedirectToAction("dashboard");

        }

        [HttpPost("joinActivity/{ActivityId}")]
        public IActionResult joinActivity(int ActivityId)
        {
            Console.WriteLine("a m in JOIN");
            int UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();;

            
            if(dbContext.ActivityMembers.Any(b=>b.ActivitiyId == ActivityId && b.UserId == UserId))
            {
                Console.WriteLine("User already a mmeber so nothing to do.Need to think if we any message needs to be sent.");
                return RedirectToAction("dashboard");

            }   
            
            ActivityMember toAdd = new ActivityMember();
            toAdd.ActivitiyId = ActivityId;
            toAdd.UserId = UserId;
            dbContext.ActivityMembers.Add(toAdd);
            dbContext.SaveChanges();

            HttpContext.Session.SetInt32("flag", 1);  

            return RedirectToAction("dashboard");
        }

        
        [HttpPost("leaveActivity/{ActivityId}")]
        public IActionResult leaveActivity(int ActivityId)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId").GetValueOrDefault();
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }

            ActivityMember ToRemove = dbContext.ActivityMembers
            .FirstOrDefault(ts => ts.ActivitiyId == ActivityId && ts.UserId == UserId);
            dbContext.Remove(ToRemove);
            dbContext.SaveChanges();
            HttpContext.Session.SetInt32("flag", 0);  

            return RedirectToAction("dashboard");
        }
        
    }
}
