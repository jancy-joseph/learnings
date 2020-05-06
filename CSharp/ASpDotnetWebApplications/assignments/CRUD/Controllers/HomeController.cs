using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using CRUD.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace CRUD.Controllers
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
            ViewBag.ReveresedDishes = dbContext.Dishes.OrderByDescending(d=>d.CreatedAt).ToList();
            return View();
        }

        [HttpGet("addDish")]
        public ViewResult addDish()
        {
            return View();
        }
        [HttpPost("createDish")]
        public IActionResult createDish(Dish dsh)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(dsh);
                dbContext.SaveChanges();
                return RedirectToAction("Index",dsh);
           }
            else
            {
                return RedirectToAction("ValidateCreatedDish",dsh);
            }

        }

        [HttpGet("createDish")]
        public IActionResult ValidateCreatedDish(Dish dsh)
        {

            return View("addDish",dsh);
        }



        [HttpGet("/edit/{DishId}")]
        public IActionResult editDish(int DishId)
        {
            if(DishId == null)
            {
                return RedirectToAction("Index");
            }

            Dish dh = dbContext.Dishes.SingleOrDefault(d=>d.DishId ==DishId);
            return View(dh);
        }

        [HttpPost("deleteDish/{DishId}")]
        public IActionResult deleteDish(int DishId)
        {
            if(DishId == null)
            {
                return RedirectToAction("Index");
            }
            Dish dh = dbContext.Dishes.SingleOrDefault(d=>d.DishId ==DishId);
            dbContext.Dishes.Remove(dh);
            dbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpPost("editOneDish/{DishId}")]
        public IActionResult editOneDish(int DishId)
        {
            if(DishId == null)
            {
                return RedirectToAction("Index");
            }
            Dish dh = dbContext.Dishes.SingleOrDefault(d=>d.DishId ==DishId);;
            return View(dh);

        }

        [HttpPost("updateDish/{DishId}")]
        public IActionResult updateDish(int DishId,Dish dsh)
        {
            if(ModelState.IsValid)
            {
                //Dish dh = dbContext.Dishes.SingleOrDefault(d=>d.DishId ==DishId);
                dsh.DishId=DishId;
                dbContext.Update(dsh);
                dbContext.Entry(dsh).Property("CreatedAt").IsModified = false;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }   
            else
            {
                return RedirectToAction("Index",dsh);
            }

        }


      
    }
}

