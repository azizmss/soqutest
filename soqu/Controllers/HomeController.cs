using Microsoft.AspNetCore.Mvc;
using soqu.Models;
using System.Diagnostics;

namespace soqu.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            soquContext db = new soquContext();
            var cat = db.Catagories.ToList();
            ViewBag.prod = db.Products.ToList();  
            return View(cat);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Categories()
        {
            soquContext db = new soquContext();
            var cat = db.Catagories.ToList();
            return View(cat);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}