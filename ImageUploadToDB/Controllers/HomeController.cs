using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageUploadToDB.Models;
using ImageUploadToDB.ViewModels;

namespace ImageUploadToDB.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext = null;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            //var products = _dbContext.Products.Select(product => new DisplayProductViewModel
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Description = product.Description,
            //    Price = product.Price,
            //    ProductImage = Convert.ToBase64String(product.ProductImage)
            //}).ToList();

            var products = _dbContext.Products.ToList();
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}