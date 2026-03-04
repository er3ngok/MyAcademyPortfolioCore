using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class UserMessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var message = context.UserMessages.ToList();
            return View(message);
        }

        public IActionResult CreateUserMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUserMessage(UserMessage message)
        {
            context.UserMessages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteUserMessage(int id)
        {
            var message = context.UserMessages.Find(id);
            context.UserMessages.Remove(message);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MessageReadTrue(int id)
        {
            var val = context.UserMessages.Find(id);
            val.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult MessageReadFalse(int id)
        {
            var val = context.UserMessages.Find(id);
            val.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            var val = context.UserMessages.Find(id);
            return PartialView("Detail", val);
        }

    }
}
