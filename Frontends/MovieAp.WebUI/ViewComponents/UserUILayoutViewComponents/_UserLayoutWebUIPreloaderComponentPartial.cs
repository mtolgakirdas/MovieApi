using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.ViewComponents.UserUILayoutViewComponents
{
    public class _UserLayoutWebUIPreloaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
