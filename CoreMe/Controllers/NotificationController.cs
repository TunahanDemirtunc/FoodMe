using Microsoft.AspNetCore.Mvc;

namespace CoreMe.Controllers
{
    public class NotificationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
