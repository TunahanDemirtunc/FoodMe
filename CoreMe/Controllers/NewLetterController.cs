﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMe.Controllers
{
	public class NewLetterController : Controller
	{
		NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());
		[HttpGet]
		public PartialViewResult SubscribeMail()
		{
			return PartialView();
		}
		[HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter p)
        {
			p.MailStatus = true;
			nm.AddNewsLetter(p);
            return PartialView();
        }
    }
}
