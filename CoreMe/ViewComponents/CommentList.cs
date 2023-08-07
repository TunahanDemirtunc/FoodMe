using CoreMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMe.ViewComponents
{
	public class CommentList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>()
			{
				new UserComment()
				{
					ID=1,
					UserName="Ahmet"
				},


				new UserComment()
				{
					ID=2,
					UserName="Tuna"
				},

                new UserComment()
                {
                    ID=3,
                    UserName="Mehmet"
                }
            };
			return View(commentvalues);
		}
	}
}
