using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.UserUILayoutViewComponents.LayoutViewComponents
{
    public class _UserLayoutWebUIHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
