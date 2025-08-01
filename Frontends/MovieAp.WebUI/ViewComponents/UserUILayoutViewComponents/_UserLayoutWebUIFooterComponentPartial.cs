using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.ViewComponents.UserUILayoutViewComponents
{
    public class _UserLayoutWebUIFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
