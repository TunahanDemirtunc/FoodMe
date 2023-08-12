using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreMe.Controllers
{
    public class RegisterController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Customer p)
        {
            CustomerValidator cv = new CustomerValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                p.CustomerStatus = true;
                p.CustomerAbout = "Deneme Test";
                cm.TAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();  


        }
    }

}
