using FoodDelivery.DataAccessLayer;
using FoodDelivery.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodDelivery.Controllers
{
    public class EnterpriseController : Controller
    {
        public IActionResult Index()
        {
            var list = DataAccess.GetEnterprieses();
            return View(list);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = DataAccess.GetEnterpriseById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(Enterprise e)
        {
            var user = DataAccess.UpdateEnterprise(e);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Enterprise e)
        {
            var user = DataAccess.AddEnterprise(e);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var user = DataAccess.DeleteEnterprise(id);
            return RedirectToAction("Index");
        }
    }
}
