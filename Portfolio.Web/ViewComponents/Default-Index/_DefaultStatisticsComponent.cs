using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultStatisticsComponent(PortfolioContext _context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.projectCount = _context.Projects.Count();
            ViewBag.skillCount = _context.Skills.Count();
            ViewBag.testimonialCount = _context.Testimonials.Count();
            ViewBag.educationCount = _context.Educations.Count();
            
            return View();
        }
    }
}
