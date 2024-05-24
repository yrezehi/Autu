using Autu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Autu.Controllers
{
    public class HomeController : Controller
    {

        public HomeController() { }
       
        public IActionResult Index() =>
            View();
        

        public IActionResult Privacy() =>
            View();
    }
}