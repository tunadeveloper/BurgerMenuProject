using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: Admin/AdminLayout
        BurgerMenuContext context = new BurgerMenuContext();    
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }
		public PartialViewResult AdminPartialReservationAdd()
		{
			return PartialView();
		}
		[HttpPost]
		public PartialViewResult AdminPartialReservationAdd(Reservation reservation)
		{
			reservation.ReservationStatus = "İşlem Bekliyor...";
			reservation.Time = DateTime.Now;
			context.Reservations.Add(reservation);
			context.SaveChanges();
			return PartialView();
		}
	}
}