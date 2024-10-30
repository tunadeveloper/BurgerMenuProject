using BurgerMenuProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class SubscriptionController : Controller
    {
        // GET: Admin/Subscription
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index(int page = 1)
        {
            int pagesize = 10;
            var values = context.Subscriptions
                .OrderByDescending(s => s.Id)
                .ToList()
                .ToPagedList(page, pagesize);
			ViewBag.TotalPages = values.PageCount;
			ViewBag.CurrentPage = page;
			return View(values);
        }
    }
}