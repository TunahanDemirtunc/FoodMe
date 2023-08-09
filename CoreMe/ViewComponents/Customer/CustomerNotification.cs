using Microsoft.AspNetCore.Mvc;

namespace CoreMe.ViewComponents.Customer
{
    public class CustomerNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
