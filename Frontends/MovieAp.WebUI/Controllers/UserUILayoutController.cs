using Microsoft.AspNetCore.Mvc;

namespace MovieAp.WebUI.Controllers
{
    public class UserUILayoutController : Controller
    {
        public IActionResult LayoutUI()
        {
            return View();
        }
    }
}
