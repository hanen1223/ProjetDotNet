using Microsoft.AspNetCore.Mvc;

namespace AM.UI.WEB.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult signin()
        {
            return RedirectToAction(nameof(Index),"Plane");
        }
    }
}
