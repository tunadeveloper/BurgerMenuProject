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
			var values = context.Messages.Where(x=>x.ReceiverEmail == email).OrderByDescending(x=>x.MessageId).Take(5).ToList();
			return View(values);
		}

		public ActionResult DashboardRezervation()
		{
			var values = context.Reservations.Where(x => x.ReservationStatus == "İşlem Bekliyor...").OrderByDescending(x=>x.ReservationId).Take(5).ToList();
			return View(values);
		}

		public ActionResult DashboardSubscription()
		{
			var values = context.Subscriptions.OrderByDescending(x=>x.Id).Take(5).ToList();
			return View(values);
		}

	}
}