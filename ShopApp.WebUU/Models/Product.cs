﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.WebUU.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool IsAppRoved { get; set; }
        public int CategoryId { get; set; }

    }
}
