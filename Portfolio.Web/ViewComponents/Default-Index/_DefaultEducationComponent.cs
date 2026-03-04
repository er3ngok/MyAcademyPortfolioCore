using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultEducationComponent(PortfolioContext _context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var educations = _context.Educations.ToList();
            return View(educations);
        }
    }
}
