using Microsoft.AspNetCore.Mvc;

namespace MyCourse_Custom.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }
        
        public IActionResult Index(){

            return View();
        }
    }
}