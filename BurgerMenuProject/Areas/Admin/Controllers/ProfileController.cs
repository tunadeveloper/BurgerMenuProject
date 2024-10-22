using BurgerMenuProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerMenuProject.Entities;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        // GET: Admin/Profile
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult MyProfileList()
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x=>x.Username == userName).FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public ActionResult MyProfileList(BurgerMenuProject.Entities.Admin admin)
        {
            var userName = Session["x"];
            var values = context.Admins.Where(x => x.Username == userName).FirstOrDefault();
            values.Username = admin.Username;
            values.Password = admin.Password;
            values.Email = admin.Email;
            values.Surname = admin.Surname;
            values.Name = admin.Name;
            context.SaveChanges();
            return RedirectToAction("Index", "Login");
        }
    }
}