using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMe.ViewComponents.Customer
{
    
    public class CustomerAboutOnDashboard : ViewComponent
    {
        CustomerManager cm = new CustomerManager(new EfCustomerRepository());
        public IViewComponentResult Invoke()
        {
            var values = cm.GetCustomerById(1);
            return View(values);
        }
    }
}
