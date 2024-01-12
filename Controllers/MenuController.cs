using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
