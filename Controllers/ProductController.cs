using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product[] myProduct = new Product[]
            {
                new Product {ProductID = 101 , Name = "Pasta",UnitPrice= 75},
                new Product {ProductID = 102 , Name = "Chesse",UnitPrice= 60},
                new Product {ProductID = 103 , Name = "Rooster",UnitPrice= 410},
                new Product {ProductID = 104 , Name = "Rice",UnitPrice= 75},
                new Product {ProductID = 105 , Name = "Oil",UnitPrice= 150},
                new Product {ProductID = 106 , Name = "Meat",UnitPrice= 120},

            };
            return View(myProduct);
        }

        public IActionResult TopProduct()
        {
            Product product1 = new Product();
            product1.ProductID = 101;
            product1.Name = "Pasta";
            product1.UnitPrice = 36;

            Product product2 = new Product();
            product2.ProductID = 105;
            product2.Name = "Cheese";
            product2.UnitPrice = 40;

            //List<Product> ProductList = new List<Product>();
            //ProductList.Add(product1);
            //ProductList.Add(product2);

            //return View(product1,product2);

            return View(product1);
        }
    }
}
