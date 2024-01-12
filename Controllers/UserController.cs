using FoodDelivery.DataAccessLayer;
using FoodDelivery.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FoodDelivery.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
           var list = DataAccess.GetUsers();
            return View(list);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = DataAccess.GetUserById(id);
            return View(user);
        }
        [HttpPost]
        public IActionResult Edit(User u)
        {
            var user = DataAccess.UpdateUser(u);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User u)
        {
            var user =DataAccess.AddUser(u);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var user = DataAccess.DeleteUser(id);
            return RedirectToAction("Index");
        }
    }
}
