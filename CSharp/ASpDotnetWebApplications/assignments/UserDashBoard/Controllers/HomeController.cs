using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UserDashBoard.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace UserDashBoard.Controllers
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
            Console.WriteLine("1");
            return View();
        }

        [HttpGet("signin")]
        public ViewResult Signin()
        {
            Console.WriteLine("2");
            return View();
        }
        [HttpGet("register")]
        public ViewResult Register()
        {
            Console.Write("3");
            return View();
        }

        [HttpPost("registerUser")]
        public IActionResult RegisterUser(User submission)
        {
//            Console.WriteLine("I am here");
            submission.Description =" ";
            submission.user_level="normal";
            if(ModelState.IsValid)
            {  
                if(dbContext.Users.Any(u=>u.Email == submission.Email))
                {
                    ModelState.AddModelError("Email","A user with this email address exists");
                    return View("Register",submission);
                }
  //              Console.WriteLine("I am here 1");

                // Initializing a PasswordHasher object, providing our User class as its type
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                submission.Password = Hasher.HashPassword(submission, submission.Password);
    //            Console.WriteLine("I am here 2");

                if(!dbContext.Users.Any())
                {
                        // The table is empty
                        submission.user_level ="admin";
      //                  Console.WriteLine("I am here 3");

                }
        //        Console.WriteLine("I am here 4");

                dbContext.Add(submission);
                dbContext.SaveChanges();
          //      Console.WriteLine("I am here 5");

                HttpContext.Session.SetInt32("UserId",submission.UserId);

                return RedirectToAction("Signin");
            }
            else{

            //    Console.Write( $"FirstName:{submission.FirstName} LastName:{submission.LastName} Email:{submission.Email}");
             //   Console.Write( $"Password:{submission.Password} confirmPw:{submission.ConfirmPW}");
              //  Console.Write( $"Description:{submission.Description} user_level:{submission.user_level}");

                Console.WriteLine();
                return View("Register");

            }
            
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUser submission)
        {
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u=>u.Email == submission.LoginEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail","Enter valid Email address");
                    return View("Signin",submission);
                }

            var hasher = new PasswordHasher<LoginUser>();
            
            // verify provided password against hash stored in db
            var result = hasher.VerifyHashedPassword(submission, userInDb.Password, submission.LoginPassword);
            
            // result can be compared to 0 for failure
            if(result == 0)
            {
                // handle failure (this should be similar to how "existing email" is handled)
                ModelState.AddModelError("LoginPassword","Passwords Do not match");
                return View("Signin",submission);
            }

            HttpContext.Session.SetInt32("UserId",userInDb.UserId);
            return RedirectToAction("Dashboard");
            
            }
            else
            {
                return View("Signin");


            }

        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard(User userInDb)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            if(UserId == null)
            {
                return RedirectToAction("Signin");
            }
                List<User> userInDBList = dbContext.Users
                .Include(t=>t.UserId)
                .Include(t=>t.FullName)
                .Include(t=>t.Email)
                .Include(t=>t.CreatedAt)
                .Include(t=>t.user_level)
                .ToList();

            //admin user
            if (userInDb.user_level == "admin")
            {
               return RedirectToAction("DashboardAdmin",userInDBList);
            }
            else// normal user
            {
                return View(userInDBList);
            }


            
        }

        [HttpGet("DashboardAdmin")]
        public IActionResult DashboardAdmin(User userInDb)
        {
            return View(userInDb);

        }
    }
}