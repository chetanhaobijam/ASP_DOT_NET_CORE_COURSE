using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Controllers_And_Actions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "Haobijam";
            ViewBag.data2 = "Chetan";
            TempData["data3"] = "Singh";
            TempData["insects"] = null;
            
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        [Route("About")]
        public IActionResult About()
        {
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View(); //ViewResult, PartialViewResult, JsonResult, etc.
            
        }

        

        
    }
}
