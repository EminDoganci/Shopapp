using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUU.Data;
using ShopApp.WebUU.Models;
using ShopApp.WebUU.ViewModels;

namespace ShopApp.WebUU.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            //Veri aktarım yötemleri -> ViewBag, Model, ViewData

            var product = new Product { Name = "Iphone X", Price = 6000, Description = "İyi telefon" };

            ViewData["Category"] = "Telefonlar";
            ViewData["Product"] = product;

            return View(product);
        }
        //localhost:500/product/list sayfası
        public IActionResult list(int? id, string q)
        {
            var products = ProductRespository.Products;
            if (id!=null)
            {
                products = products.Where(p=>p.CategoryId==id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.Contains(q)).ToList();
            }
            var productViewModel = new ProductViewModel()
            {

                Products = products
            };

            return View(productViewModel);
        }
        public IActionResult Details(int id)
        {
           
            return View(ProductRespository.GetProductById(id));
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            ProductRespository.AddProduct(p);
            return RedirectToAction("list");
        }
    }
}
