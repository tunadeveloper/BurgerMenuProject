using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        // GET: Admin/Reservation
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index(int page = 1)
        {
            int pagesize = 7;
            var values = context.Reservations
                .OrderByDescending(x=>x.ReservationId)
				.ToList()
				.ToPagedList(page, pagesize);
			ViewBag.TotalPages = values.PageCount;
			ViewBag.CurrentPage = page;
			return View(values);
            
        }

        public ActionResult CancelReservation(int id)
        {
            var reservation = context.Reservations.Find(id);
            if (reservation != null)
            {
                reservation.ReservationStatus = "Reddedildi";
                context.SaveChanges();
               
            }

            return RedirectToAction("Index", "Reservation", new {area = "Admin"});
        }

        public ActionResult HoldReservation(int id)
        {
            var reservation = context.Reservations.Find(id);
            if (reservation != null)
            {
                reservation.ReservationStatus = "Bekliyor";
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Reservation", new { area = "Admin" });
        }

        public ActionResult ConfirmedReservation(int id)
        {
            var reservation = context.Reservations.Find(id);
            if(reservation != null)
            {
                reservation.ReservationStatus = "Onaylandı";
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Reservation", new { area = "Admin" });
        }

    }
}