using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMe.ViewComponents.Customer
{
    public class CustomerMessageNotification: ViewComponent
    {
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}
