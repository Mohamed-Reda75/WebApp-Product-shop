using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp1.Models;


namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            if (!TempData.ContainsKey("ProfileName"))
            {
                TempData.Add("ProfileName", "Admin Profile");
            }
            
            return View();
        }

        public string TestString()
        {
            return "Welcome To TestString";
        }
        public  IActionResult TestView(int? id ,string course,byte hours)
        {
            ViewBag.MyName = "Mohamed Reda";
            ViewData.Add("MyCompany", "CLS");
            ViewBag.id = id;
            ViewBag.MyCourse = course;
            ViewBag.MyHours = hours;

            ViewBag.MyProfile = TempData["ProfileName"];
            TempData.Keep("ProfileName");

            Product product2 = new Product();
            product2.ProductID = 105;
            product2.Name = "Cheese";
            product2.UnitPrice = 40;

            return View(product2);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
