using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SettingsController(PortfolioContext context) : Controller
    {
        public IActionResult Users()
        {
            var users = context.Users.ToList();
            return View(users);
        }

        [HttpGet]
        public IActionResult UserPassword(int id)
        {
            var user = context.Users.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult UserPassword(User user)
        {
            User pass = context.Users.FirstOrDefault();
            if (pass.Password == user.Password)
            {
                return RedirectToAction("UpdateUser", "Settings");
            }
            return View();
        }

        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var user = context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("Users");
        }
    }
}
