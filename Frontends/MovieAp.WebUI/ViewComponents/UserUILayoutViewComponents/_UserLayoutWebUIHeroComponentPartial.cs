using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.ViewComponents.UserUILayoutViewComponents
{
    public class _UserLayoutWebUIHeroComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
