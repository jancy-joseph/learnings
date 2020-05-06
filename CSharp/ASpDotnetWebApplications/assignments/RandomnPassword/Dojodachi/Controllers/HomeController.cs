using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
namespace Dojodachi.Controllers
{
    public class HomeController: Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            djdachi dachi = new djdachi();
            Helper.GameResult(ref dachi);
            return RedirectToAction("success", dachi);
        }

        [HttpGet("success")]
        public ViewResult success(djdachi dachi)
        {
            return View(dachi);
        }        
        
        [HttpPost("feed")]
        public IActionResult feed(djdachi dachi)
        {
            dachi.Feed();
            Console.WriteLine($"full:{dachi.Fullness}Meals:{dachi.Meals}happi:{dachi.Happiness}Energy:{dachi.Energy}");
            Helper.GameResult(ref dachi);
            if(dachi.showBtnFlag == true)
            {
                return RedirectToAction("gameRestart");
            }
            else
            {        
                return RedirectToAction("success",dachi);
            }
        }
        [HttpPost("play")]
        public IActionResult play(djdachi dachi)
        {   
            dachi.Play();
            Helper.GameResult(ref dachi);
            if(dachi.showBtnFlag == true)
            {
                return RedirectToAction("gameRestart");
            }
            else
            {
                return RedirectToAction("success",dachi);
            }
        }
        [HttpPost("work")]
        public IActionResult work(djdachi dachi)
        {
            dachi.Work();
            Helper.GameResult(ref dachi);
            if(dachi.showBtnFlag == true)
            {
                return RedirectToAction("gameRestart");
            }
            else
            {
                return RedirectToAction("success",dachi);
            }
        }
        [HttpPost("sleep")]
        public IActionResult sleep(djdachi dachi)
        {
            dachi.Sleep();
            Helper.GameResult(ref dachi);
            if(dachi.showBtnFlag == true)
            {
                return RedirectToAction("gameRestart");
            }
            else
            {
                return RedirectToAction("success",dachi);
            }
        }


       [HttpPost("gameRestart")]
       public IActionResult gameRestart()
       {
            return RedirectToAction("Index");           
       }
    }
}