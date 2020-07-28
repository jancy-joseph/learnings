using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            string  mystring = "hello";
            return View("index",mystring);
        }

        [HttpGet("numbers")]
        public IActionResult numbers(){
            int[] nums = new int[]{1,2,3,4,35,6,7};

            return View(nums);

        }
        
        [HttpGet("users")]
        public IActionResult users(){
            User user1 = new User("Moose","Phillips");
            User user2 = new User("Sarah");
            User user3 = new User("Jerry");
            User user4 = new User("Rene","Ricky");
            User user5 = new User("Barbarah");
            List<User> userlist = new List<User>();
            userlist.Add(user1);
            userlist.Add(user2);
            userlist.Add(user3);
            userlist.Add(user4);
            userlist.Add(user5);
            return View(userlist);

        }
        [HttpPost("user")]
        public IActionResult user(User user1){
            Console.WriteLine(user1.firstName);
            return View(user1);

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
