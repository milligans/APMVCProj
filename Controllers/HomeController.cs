using AllplantsSelector.DAL;
using AllplantsSelector.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AllplantsSelector.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IConfiguration _configuration;
        private AllplantsContext db = new AllplantsContext();

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
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
