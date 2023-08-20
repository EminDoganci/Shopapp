using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.WebUU.Models;

namespace ShopApp.WebUU.Data
{
    public static class ProductRespository
    {
        private static List<Product> _products = null;

        static ProductRespository()
        {
            _products = new List<Product>
            {
                new Product {ProductId=1, Name = "Iphone 7", Price= 3000, Description = "İyi Telefon", IsAppRoved = false, ImageUrl="1.jpg", CategoryId=1},
                new Product {ProductId=2, Name = "Iphone 8", Price= 4000, Description = "Çok iyi Telefon", IsAppRoved = true, ImageUrl="2.jpg", CategoryId=1},
                new Product {ProductId=3, Name = "Iphone X", Price= 5000, Description = "Çok iyi Telefon", IsAppRoved = true, ImageUrl="3.jpg", CategoryId=1},
                new Product {ProductId=4, Name = "Iphone 11", Price= 6000, Description = "Çok iyi Telefon", ImageUrl="4.jpg", CategoryId=1},
                new Product {ProductId=5, Name = "Iphone 12", Price= 6000, Description = "Çok iyi Telefon", ImageUrl="4.jpg", CategoryId=1},
                new Product {ProductId=6, Name = "Lenova 7", Price= 3000, Description = "İyi bilgisayar", IsAppRoved = false, ImageUrl="1.jpg", CategoryId=2},
                new Product {ProductId=7, Name = "Lenova 8", Price= 4000, Description = "Çok iyi bilgisayar", IsAppRoved = true, ImageUrl="2.jpg", CategoryId=2},
                new Product {ProductId=8, Name = "Lenova X", Price= 5000, Description = "Çok iyi bilgisayar", IsAppRoved = true, ImageUrl="3.jpg", CategoryId=2},
                new Product {ProductId=9, Name = "Lenova 11", Price= 6000, Description = "Çok iyi bilgisayar", ImageUrl="4.jpg", CategoryId=2}
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
