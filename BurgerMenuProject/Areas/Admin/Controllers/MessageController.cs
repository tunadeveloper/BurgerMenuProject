using BurgerMenuProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using BurgerMenuProject.Entities;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
	public class MessageController : Controller
	{
		// GET: Admin/Message

		BurgerMenuContext context = new BurgerMenuContext();

		public ActionResult Inbox()
		{
			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
			var values = context.Messages.Where(x => x.ReceiverEmail == email).ToList();
			return View(values);
		}

		public PartialViewResult PartialSendBox()
		{
			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
			var values = context.Messages.Where(x => x.SenderEmail == email).ToList();
			return PartialView(values);
		}

		public ActionResult NewMessage()
		{
			List<SelectListItem> items = new List<SelectListItem>
			{
		new SelectListItem { Value = "Destek", Text = "Destek" },
		new SelectListItem { Value = "Teşekkür", Text = "Teşekkür" },
		new SelectListItem { Value = "Duyuru", Text = "Duyuru" },
		new SelectListItem { Value = "Finans", Text = "Finans" },
		new SelectListItem { Value = "Menü", Text = "Menü" },
		new SelectListItem { Value = "Diğer", Text = "Diğer" }

			};
			ViewBag.Items = items;
			return View();
		}

		[HttpPost]
		public ActionResult NewMessage(BurgerMenuProject.Entities.Message message, string SelectedItem)
		{
			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
			message.SenderEmail = email;
			message.SendDate = DateTime.Now;
			context.Messages.Add(message);
			context.SaveChanges();
			return RedirectToAction("Inbox", "Message", new { area = "Admin" });
		}
	}
}