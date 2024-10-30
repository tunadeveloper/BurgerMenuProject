using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class CreditCardController : Controller
    {
        // GET: Admin/CreditCard
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CreditCard cc)
        {
           context.CreditCards.Add(cc);
            context.SaveChanges();
            return View();
        }

        public PartialViewResult CreditCardList()
        {
            var value = context.CreditCards.ToList();
            return PartialView(value);
        }

        public ActionResult DeleteCreditCard(int id)
        {
            var value = context.CreditCards.Find(id);
            context.CreditCards.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index", "CreditCard");
        }
    }
}