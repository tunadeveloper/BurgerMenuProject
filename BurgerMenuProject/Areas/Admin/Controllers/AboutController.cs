using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        // GET: Admin/About
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        public ActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
		public ActionResult UpdateAbout(About about)
		{
			var value = context.Abouts.Find(about.Id);
            value.AboutText = about.AboutText;
            value.AboutImage = about.AboutImage;
            value.WelcomeImage = about.WelcomeImage;
            value.WelcomeText = about.WelcomeText;
            context.SaveChanges();
            return RedirectToAction("Index", "About", new {Areas = "Admin"});

		}
	}
}