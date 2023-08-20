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
    public class HomeController : Controller
    {

        public IActionResult Index()
        {

            var productViewModel = new ProductViewModel()
            {
               
                Products = ProductRespository.Products
            };

            return View(productViewModel);
        }
        //localhost:500/home/about sayfası
        public IActionResult About()
        {
            return View();
        }
    }
}
