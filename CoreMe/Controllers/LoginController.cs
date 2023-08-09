using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreMe.Controllers
{
	public class LoginController : Controller
	{
		[AllowAnonymous]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
        [AllowAnonymous]
        public async Task <IActionResult> Index(Customer p)
		{
	      Context c= new Context();
			var datavalue = c.Customers.FirstOrDefault(x => x.CustomerMail == p.CustomerMail && x.CustomerPassword == p.CustomerPassword);
			if (datavalue == null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name,p.CustomerMail)
				};
				var useridentity = new ClaimsIdentity(claims, "a");
				ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				return RedirectToAction("Index", "Customer");
			}
			else
			{
				return View();
			}
		}
	}
}
//Context c = new Context();
//var datavalue = c.Customers.FirstOrDefault(x => x.CustomerMail == p.CustomerMail &&
// x.CustomerPassword == p.CustomerPassword);
//if (datavalue == null)
//{
//    HttpContext.Session.SetString("username", p.CustomerMail);
//    return RedirectToAction("Index", "Customer");
//}
//else
//{
//    return View();

//}