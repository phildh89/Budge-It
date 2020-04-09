using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BudgeIt.Models;

namespace BudgeIt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //TODO: Copy below to reach Views
        public IActionResult Index()
        {
            //TODO: If logged in return summary. If not, return login view.
            return View();
        }
        public IActionResult Savings()
        {
            return View();
        }
        public IActionResult Debts()
        {
            return View();
        }
        public IActionResult Checkings()
        {
            return View();
        }
        public IActionResult Calculator()
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
