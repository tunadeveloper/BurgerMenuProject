using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Data.Entity;
namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
		// GET: Admin/Chart
		BurgerMenuContext context = new BurgerMenuContext();
		public ActionResult Index()
		{
			var reservations = context.Reservations.ToList();

			var reservationCounts = reservations
				.GroupBy(r => new { r.Time.Year, r.Time.Month })
				.Select(g => new
				{
					Year = g.Key.Year,
					Month = g.Key.Month,
					Count = g.Count()
				})
				.ToList();

			ViewBag.ReservationData = JsonConvert.SerializeObject(reservationCounts);

			var products = context.Products.Include(p => p.Category).ToList();
			var productCounts = products
				.GroupBy(p => p.Category.CategoryName) 
				.Select(g => new
				{
					CategoryName = g.Key,
					Count = g.Count()
				})
				.ToList();
			ViewBag.ProductData = JsonConvert.SerializeObject(productCounts);

			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();

			var userMessages = context.Messages
				.Where(m => m.SenderEmail == email)
				.GroupBy(m => m.Title)
				.Select(g => new
				{
					Title = g.Key,
					Count = g.Count()
				})
				.ToList();

			ViewBag.MessageData = JsonConvert.SerializeObject(userMessages);
			var subscriptions = context.Subscriptions.ToList();
			var subscriptionCounts = subscriptions
				.GroupBy(s => s.dateTime.Date)
				.Select(g => new
				{
					Date = g.Key,
					Count = g.Count()
				})
				.ToList();

			ViewBag.SubscriptionData = JsonConvert.SerializeObject(subscriptionCounts);

			return View();
		}

	}
}