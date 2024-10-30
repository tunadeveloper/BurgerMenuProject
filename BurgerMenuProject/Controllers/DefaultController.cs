using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using Microsoft.Win32;
namespace BurgerMenuProject.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()    
        {
			return View();
        }

        [HttpPost]
		public ActionResult Index(UserMessage userMessage)

		{
			context.UserMessages.Add(userMessage);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {

            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFooter()
        {
            var values = context.SocialMedia.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialGallery()
        {
            var values = context.Gallerys.ToList();
            return PartialView(values);
        }

		public PartialViewResult PartialMenu()
		{
			var products = context.Products.ToList();
			return PartialView("PartialMenu", products);
		}

		public PartialViewResult PartialNavbar()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialCategory()
        {
			var values = context.Categories.Take(6).ToList();
			return PartialView("PartialCategory", values);
		}

        public PartialViewResult TodaysOffer()
        {
           var values =context.Products.Where(x=>x.DealofTheDay == true).ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult PartialReservation()
        {
            return PartialView();
        }

		[HttpPost]
		public PartialViewResult PartialReservation(Reservation reservation)
		{
			
				reservation.ReservationStatus = "İşlem Bekliyor...";
				reservation.Time = DateTime.Now;
				context.Reservations.Add(reservation);
				context.SaveChanges();
				return PartialView();
			}


		public PartialViewResult PartialContact()
        {
            var values = context.Contacts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialMap() { 
        ViewBag.mapurl = context.Contacts.Select(x=>x.MapUrl).FirstOrDefault();
        return PartialView();
        }
 
        public PartialViewResult PartialContactHead()
        {
            ViewBag.description = context.Contacts.Select(x=> x.Description).FirstOrDefault();
            return PartialView();
        }

        public PartialViewResult PartialFooterAbout()
        {
            ViewBag.description = context.Abouts.Select(x=>x.AboutText).FirstOrDefault();
            return PartialView();
        }

        public ActionResult PartialSubscription()
        {
            return PartialView();
        }

        [HttpPost]
		public ActionResult PartialSubscription(Subscription subscription)
		{
            if (ModelState.IsValid)
            {
                context.Subscriptions.Add(subscription);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Default");
		}
	}
	}
