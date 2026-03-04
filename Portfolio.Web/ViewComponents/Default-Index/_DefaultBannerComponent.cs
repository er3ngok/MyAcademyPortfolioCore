using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultBannerComponent(PortfolioContext _context) : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var banners = _context.Banners.ToList();
            return View(banners);
        }
    }
}
