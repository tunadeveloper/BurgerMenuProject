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
			// Veritabanından rezervasyonları al
			var reservations = context.Reservations.ToList();

			// Aylara göre rezervasyon sayısını gruplama
			var reservationCounts = reservations
				.GroupBy(r => new { r.Time.Year, r.Time.Month })
				.Select(g => new
				{
					Year = g.Key.Year,
					Month = g.Key.Month,
					Count = g.Count()
				})
				.ToList();

			// Modeli JSON formatına çevir
			ViewBag.ReservationData = JsonConvert.SerializeObject(reservationCounts);

			// Ürünleri al ve kategorilere göre sayısını gruplama
			var products = context.Products.Include(p => p.Category).ToList();
			var productCounts = products
				.GroupBy(p => p.Category.CategoryName) // Kategori adı ile gruplama
				.Select(g => new
				{
					CategoryName = g.Key,
					Count = g.Count()
				})
				.ToList();

			// Ürün verisini JSON formatına çevir
			ViewBag.ProductData = JsonConvert.SerializeObject(productCounts);

			// Giriş yapan kullanıcının bilgilerini al
			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();

			// Kullanıcının mesajlarını al
			var userMessages = context.Messages
				.Where(m => m.SenderEmail == email)
				.GroupBy(m => m.Title)
				.Select(g => new
				{
					Title = g.Key,
					Count = g.Count()
				})
				.ToList();

			// Mesaj verisini JSON formatına çevir
			ViewBag.MessageData = JsonConvert.SerializeObject(userMessages);

			// Kullanıcı aboneliklerini al
			var subscriptions = context.Subscriptions.ToList();

			// Günlere göre abonelik sayısını gruplama
			var subscriptionCounts = subscriptions
				.GroupBy(s => s.dateTime.Date) // Sadece tarih kısmını alıyoruz
				.Select(g => new
				{
					Date = g.Key,
					Count = g.Count()
				})
				.ToList();

			// Mesaj verisini JSON formatına çevir
			ViewBag.SubscriptionData = JsonConvert.SerializeObject(subscriptionCounts);

			return View();
		}

	}
}