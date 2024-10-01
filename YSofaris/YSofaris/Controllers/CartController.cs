using Microsoft.AspNetCore.Mvc;

namespace YSofaris.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       // public IActionResult Add(int id) { return RiderectToAction(); }
    }
}
