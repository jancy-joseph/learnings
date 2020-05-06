using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ProductCategories.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace ProductCategories.Controllers
{
    public class HomeController:Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext= context;
        }

        [HttpGet("")]
        public IActionResult Index(ProductWrapper submission)
        {
            ProductWrapper vMod = new ProductWrapper();
            vMod.AllProducts= dbContext.Products
                     .Include(p=>p.CategoriesInProducts)
                     .ThenInclude(c=>c.Category)
                    .ToList();
            return View(vMod);
        }

        [HttpPost("createNewProduct")]
        public IActionResult createNewProduct(ProductWrapper submission)
        {
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(submission.newProduct);
                dbContext.SaveChanges();
                return RedirectToAction("Index",submission);
            }
            else
            {
                return RedirectToAction("Index",submission);
            }
        }

        [HttpGet("ARSAllCat")]
        public IActionResult ARSAllCat(CategoryWrapper submission)
        {
            CategoryWrapper vMod = new CategoryWrapper();
            vMod.AllCategories = dbContext.Categories
            .Include(p=>p.ProductswithCategories)
            .ThenInclude(x=>x.Product)
            .ToList();
            return View(vMod);
        }

        [HttpPost("createNewCategory")]
        public IActionResult createNewCategory(CategoryWrapper submission)
        {
            if(ModelState.IsValid)
            {
                dbContext.Categories.Add(submission.newCategory);
                dbContext.SaveChanges();
                return RedirectToAction("ARSAllCat",submission);
            }
            else
            {
                return RedirectToAction("ARSAllCat",submission);
            }

        }

        [HttpGet("edit/{ProductId}")]
        public IActionResult editOneProd(int ProductId)
        {
            // int? UserId = HttpContext.Session.GetInt32("UserId");
            // if(UserId == null)
            // {
            //     return RedirectToAction("Index");
            // }
            editProdAssociationWrapper vMod = new editProdAssociationWrapper();
            vMod.currProduct = dbContext.Products
                .Include(p=>p.CategoriesInProducts)
                .ThenInclude(cx=>cx.Category)
                .FirstOrDefault(p => p.ProductId == ProductId);
            vMod.AllCategory = dbContext.Categories.ToList();

            return View("editOneProd", vMod);
        }

        [HttpPost("newAssociation/{ProductId}")]
        public IActionResult newAssociation(int ProductId,editProdAssociationWrapper submission)
        {
            submission.association.ProductId= ProductId;
            if(ModelState.IsValid)
            {
                dbContext.Add(submission.association);
                dbContext.SaveChanges();
                return RedirectToAction("editOneProd",new{ProductId=ProductId});
            }
            else
            {
                return RedirectToAction("editOneProd",new{ProductId =ProductId});
            }
        }

        [HttpGet("edit/{CategoryId}")]
        public IActionResult editOneCat(int CategoryId)
        {
            // int? UserId = HttpContext.Session.GetInt32("UserId");
            // if(UserId == null)
            // {
            //     return RedirectToAction("Index");
            // }
            editCatAsssociationWrapper vMod = new editCatAsssociationWrapper();
            vMod.currCategory = dbContext.Categories
                .Include(c=>c.ProductswithCategories)
                .ThenInclude(px=>px.Product)
                .FirstOrDefault(p => p.CategoryId == CategoryId);
            vMod.AllProducts = dbContext.Products.ToList();

            return View("editOneCat", vMod);
        }

        [HttpPost("newCatAssociation/{CategoryId}")]
        public IActionResult newCatAssociation(int CategoryId,editProdAssociationWrapper submission)
        {
            submission.association.CategoryId= CategoryId;
            if(ModelState.IsValid)
            {
                dbContext.Add(submission.association);
                dbContext.SaveChanges();
                return RedirectToAction("editOneCat",new{CategoryId=CategoryId});
            }
            else
            {
                return RedirectToAction("editOneCrod",new{CategoryId =CategoryId});
            }
        }


    }
}