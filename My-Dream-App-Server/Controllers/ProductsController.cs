﻿using My_Dream_App_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace My_Dream_App_Server.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M },
            new Product { Id = 4, Name = "Star", Category = "Heavens", Price = 116.99M },
            new Product { Id = 5, Name = "Hero", Category = "Angular", Price = 216.99M },
            new Product { Id = 6, Name = "Dream", Category = "Heavens", Price = 316.99M },
            new Product { Id = 7, Name = "Banana", Category = "Food", Price = 4.02M },
            new Product { Id = 8, Name = "Chocolate", Category = "Food", Price = 5.03M },
            new Product { Id = 9, Name = "Vanilla", Category = "Food", Price = 13.90M },
            new Product { Id = 10, Name = "Vodka", Category = "Food", Price = 6.00M },
            new Product { Id = 11, Name = "Coke", Category = "Food", Price = 5.99M },
            new Product { Id = 12, Name = "Sugar", Category = "Food", Price = 5.98M },
            new Product { Id = 13, Name = "Screwdriver", Category = "Hardware", Price = 1.99M },
            new Product { Id = 14, Name = "Jack", Category = "Hardware", Price = 2.99M },
            new Product { Id = 15, Name = "Doll", Category = "Toys", Price = 3.99M },

        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}