using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;

namespace Portfolio.Web.Controllers
{
    public class AccountController(PortfolioContext context) : Controller
    {
        [HttpGet]
        public IActionResult Edit(int id = 1)
        {
            var admin = context.Users.FirstOrDefault(u => u.UserId == id);
            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }

        [HttpPost]
        public IActionResult Edit(int id, string userName, string currentPassword, string? newPassword, string? confirmPassword)
        {

            var admin = context.Users.FirstOrDefault(u => u.UserId == id);
            if (admin == null)
            {
                return NotFound();
            }

            admin.UserName = userName;

            if (!string.IsNullOrEmpty(newPassword))
            {

                if (admin.Password != currentPassword)
                {
                    ModelState.AddModelError("", "Mevcut şifre yanlış!");
                    return View(admin);
                }

                if (newPassword != confirmPassword)
                {
                    ModelState.AddModelError("", "Yeni şifre ile doğrulama şifresi eşleşmiyor!");
                    return View(admin);
                }

                admin.Password = newPassword;
            }

            context.SaveChanges();
            ViewBag.Message = "Profil başarıyla güncellendi.";

            return View(admin);
        }


    }
}
