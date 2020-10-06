using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageUploadToDB.Models;
using ImageUploadToDB.ViewModels;

namespace ImageUploadToDB.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext _dbContext = null;

        public ProductsController()
        {
            _dbContext = new ApplicationDbContext();
            
        }

        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddProductViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            byte[] img = new byte[viewModel.ImageData.InputStream.Length];
            viewModel.ImageData.InputStream.Read(img, 0, img.Length);

            Product product = new Product
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                Price = viewModel.Price,
                ProductImage = img
            };

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}