using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultExperienceComponent(PortfolioContext _context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var experiences = _context.Experiences.ToList();
            return View(experiences);
        }
    }
}
