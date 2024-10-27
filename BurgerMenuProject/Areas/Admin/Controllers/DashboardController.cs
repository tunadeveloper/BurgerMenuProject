using BurgerMenuProject.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
	public class DashboardController : Controller
	{
		BurgerMenuContext context = new BurgerMenuContext();
		public ActionResult Index()
		{
			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault(); 
			ViewBag.Inbox = context.Messages.Where(x=>x.ReceiverEmail == email).Count();
			ViewBag.SendBox = context.Messages.Where(x => x.SenderEmail == email).Count();

			return View();
		}


	}





}