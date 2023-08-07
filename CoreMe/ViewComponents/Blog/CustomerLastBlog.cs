using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMe.ViewComponents.Blog
{
	public class CustomerLastBlog : ViewComponent
	{
		BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListByCustomer(1);
            return View(values);
        }
    }
}
