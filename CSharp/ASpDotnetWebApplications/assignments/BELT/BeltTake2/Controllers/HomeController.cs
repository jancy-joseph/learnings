using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BeltTake2.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BeltTake2.Controllers
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

            DashboardWrapper vMod = new DashboardWrapper();

            vMod.LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)UserId);
            vMod.AllIdeas= dbContext.Ideas
            .Include(t=>t.User)
            .Include(t=>t.Likes)
            .OrderByDescending(t=>t.Likes.Count()).ToList();            
             return View(vMod);
        }

        [HttpPost("addPost")]
        public IActionResult addPost(DashboardWrapper submission)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index");
            } 
            if(ModelState.IsValid)
            {
                submission.newIdea.User = dbContext.Users.FirstOrDefault(u => u.UserId == (int)UserId);
               // submission.newIdea.User.UserId =  (int)UserId;
                dbContext.Add(submission.newIdea);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard",submission);
           }
            else
            {
                return RedirectToAction("addPost",submission);
            }

        }

        [HttpPost("addLike/{IdeaId}")]
        public IActionResult addLike(int IdeaId,DashboardWrapper submission)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Index");
            }
            if(ModelState.IsValid)
            {
                if(dbContext.Likes.Any(r => r.UserId == (int)UserId && r.IdeaId == IdeaId))
                {
                  //  ModelState.AddModelError("ReviewForm.Rating", "You have already left a review for this truck.");
                    return RedirectToAction("Dashboard",submission);
                }
                submission.newIdea.IdeaId = dbContext.Ideas.SingleOrDef
                submission.newIdea.UserId = (int)UserId;
                Like toAdd = new Like();
                toAdd.IdeaId = submission.newIdea.IdeaId;
                toAdd.UserId = submission.newIdea.UserId;
                submission.newIdea.Likes.Add(toAdd);// add like to post
                dbContext.Add(toAdd);//add like
                dbContext.Update(submission.newIdea);//add post 
                dbContext.Entry(submission.newIdea).Property("CreatedAt").IsModified = false;
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard",submission);       
            }
            else
            {
                return RedirectToAction("Dashboard");   
            }
        }
        
    }
}
