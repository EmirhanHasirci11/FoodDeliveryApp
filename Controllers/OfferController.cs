using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers
{
    public class OfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
