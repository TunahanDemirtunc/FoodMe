using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreMe.Models;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;

namespace CoreMe.Controllers
{
	
    public class CustomerController : Controller
	{
		CustomerManager cm = new CustomerManager(new EfCustomerRepository());
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
		[AllowAnonymous]
		[HttpGet]
		public IActionResult CustomerEditProfile()
		{
			var customervalues = cm.TGetById(1);
			return View(customervalues);
		}
		[HttpPost]
		public IActionResult CustomerEditProfile(Customer p)
		{
			CustomerValidator cl = new CustomerValidator();
			ValidationResult result = cl.Validate(p);
			if (result.IsValid)
			{
				cm.TUpdate(p);
				return RedirectToAction("Index", "Dashboard");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
		[AllowAnonymous]
		[HttpGet]
		public IActionResult CustomerAdd()
		{
			return View();
		}
        [AllowAnonymous]
        [HttpPost]
        public IActionResult CustomerAdd(AddProfileImage p)
		{
			Customer c = new Customer();
			if (p.CustomerImage != null)
			{
				var extension = Path.GetExtension(p.CustomerImage.FileName);
				var newimagename = Guid.NewGuid() + extension;
				var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/CustomerImageFiles/", newimagename);
				var stream = new FileStream(location, FileMode.Create);
				p.CustomerImage.CopyTo(stream);
				c.CustomerImage = newimagename;
			}
			c.CustomerMail = p.CustomerMail;
			c.CustomerName = p.CustomerName;
			c.CustomerPassword = p.CustomerPassword;
			c.CustomerStatus = true;
			c.CustomerAbout = p.CustomerAbout;
			cm.TAdd(c);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
