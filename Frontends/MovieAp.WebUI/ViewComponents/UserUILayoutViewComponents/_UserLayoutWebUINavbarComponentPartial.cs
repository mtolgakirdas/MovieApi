using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.ViewComponents.UserUILayoutViewComponents
{
    public class _UserLayoutWebUINavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    
}
