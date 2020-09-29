using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab8.Models;

namespace Lab8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Test1()
        {
            int n1 = 5, n2 = 6;
            int sum = n1 + n2;
            ViewBag.n1 = n1.ToString();
            ViewBag.n2 = n2.ToString();
            ViewBag.sum = sum.ToString();
            return View();
        }
        [HttpGet]
        public ViewResult Test2()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Test2(int n1,int n2)
        {
            Console.WriteLine(n1.ToString());
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            ViewBag.sum = (n1+n2).ToString();
            return View("Test2");
        }

        public ViewResult user_registration()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
