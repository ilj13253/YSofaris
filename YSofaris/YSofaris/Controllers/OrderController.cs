using Microsoft.AspNetCore.Mvc;

namespace YSofaris.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
