using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class SocialsController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var socials = context.Socials.ToList();
            return View(socials);
        }

        public IActionResult CreateSocials()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSocials(Socials socials)
        {
            context.Socials.Add(socials);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocials(int id)
        {
            var socials = context.Socials.Find(id);
            context.Socials.Remove(socials);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSocials(int id)
        {
            var socials = context.Socials.Find(id);
            return View(socials);
        }

        [HttpPost]
        public IActionResult UpdateSocials(Socials socials)
        {
            context.Socials.Update(socials);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
