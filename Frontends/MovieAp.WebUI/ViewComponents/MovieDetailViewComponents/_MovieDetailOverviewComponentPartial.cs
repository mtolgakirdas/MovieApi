using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailOverviewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
