using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailRateComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
