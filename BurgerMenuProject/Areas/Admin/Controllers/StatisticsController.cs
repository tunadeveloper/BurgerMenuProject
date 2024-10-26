using BurgerMenuProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Admin/Statistics
        BurgerMenuContext context = new BurgerMenuContext();    
        public ActionResult Index()
        {
			var userName = Session["x"];
			var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
			ViewBag.CategoryCount = context.Categories.Count();
            ViewBag.ProductCount = context.Products.Count();
            ViewBag.ReservationCount = context.Reservations.Count();
            ViewBag.InboxCount = context.Messages.Where(x => x.ReceiverEmail == email).Count();
            ViewBag.SendboxCount = context.Messages.Where(x => x.SenderEmail == email).Count();
            ViewBag.SubsriptionsCount = context.Subscriptions.Count();
            ViewBag.ProductMinPrice = context.Products.Select(x=>x.Price).Min();
            ViewBag.ProductAveragePrice = context.Products.Select(x=>x.Price).Average();
            ViewBag.ProductMaxPrice = context.Products.Select(x=>x.Price).Max();
            ViewBag.AdminCount = context.Admins.Count();
            ViewBag.CreditCardCount = context.CreditCards.Count();
            ViewBag.DealOfTheDayCount = context.Products.Where(x=>x.DealofTheDay == true).Count();

           
			return View();
        }
    }
}