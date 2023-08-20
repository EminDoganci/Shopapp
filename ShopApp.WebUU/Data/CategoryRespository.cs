using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUU.Models;

namespace ShopApp.WebUU.Data
{
    public class CategoryRespository
    {
        private static List<Category> _categories = null;

        static CategoryRespository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1, Name = "Telefonlar", Description = "Telefonlar kategorisi" },
                new Category {CategoryId=2, Name = "Bilgisayarlar", Description = "Bilgisayarlar kategorisi" },
                new Category {CategoryId=3, Name = "Elektronik", Description = "Elektronik kategorisi" }
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetPCategoryById(int id)
        {
            return _categories.FirstOrDefault(c => c.CategoryId == id);
        }


    }

}
