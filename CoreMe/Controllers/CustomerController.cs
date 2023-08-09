using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreMe.Controllers
{
	
    public class CustomerController : Controller
	{
		
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult CustomerProfile()
		{
			return View();
		}
		public IActionResult CustomerMail()
		{
			return View();
		}
		[AllowAnonymous]
		public IActionResult Test()
		{
			return View();
		}
		[AllowAnonymous]
		public PartialViewResult CustomerNavbarPartial()
		{
			return PartialView();
		}
        [AllowAnonymous]
        public PartialViewResult CustomerFooterPartial()
		{
			return PartialView();
		}
	}
}
