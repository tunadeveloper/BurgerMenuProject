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
    public class DefaultController : Controller
    {
        // GET: Default
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
            
        {
            return View();
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
            return PartialView();
        }

        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }

        public PartialViewResult PartialMenu()
        {
            var values = context.Products.ToList();
            return PartialView(values);
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
            var value = context.Categories.Take(6).ToList();
            return PartialView(value);   
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
            reservation.ReservationStatus = "Onay Bekleniyor";
            context.Reservations.Add(reservation);
            context.SaveChanges();
            return PartialView();
        }

        public ActionResult CategoryProduct(int categoryId)
        {
            var products = context.Products.Where(x=>x.CategoryId == categoryId).ToList();
            return View(products);
        }
    }
}