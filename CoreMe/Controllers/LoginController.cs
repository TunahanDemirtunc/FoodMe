using Microsoft.AspNetCore.Mvc;

namespace CoreMe.Controllers
{
	public class LoginController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
