using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultSkillsComponent(PortfolioContext _context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var skills = _context.Skills.ToList();
            return View(skills);
        }
    }
}
