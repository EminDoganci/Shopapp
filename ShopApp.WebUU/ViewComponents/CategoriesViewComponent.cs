using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopApp.WebUU.Data;
using ShopApp.WebUU.Models;

namespace ShopApp.WebUU.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CategoryRespository.Categories);
        }
    }
}
