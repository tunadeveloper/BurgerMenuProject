using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    public class SettingsController : Controller
    {
        // GET: Admin/Settings
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialGallery()
        {
            var values = context.Gallerys.ToList();
            return PartialView(values);
        }

		public ActionResult UpdateImage(int id)
		{
			var value = context.Gallerys.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateImage(Gallery gallery)
		{
			var value = context.Gallerys.Find(gallery.ImageId);
			value.ImageUrl = gallery.ImageUrl;
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public ActionResult DeleteImage(int id)
		{
			var value =context.Gallerys.Find(id);
			context.Gallerys.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public ActionResult CreateImage()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CreateImage(Gallery gallery)
		{
			context.Gallerys.Add(gallery);
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public PartialViewResult PartialContact()
		{
			var values = context.Contacts.ToList();
			return PartialView(values);
		}
		public ActionResult UpdateContact(int id)
		{
			var value = context.Contacts.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateContact(Contact contact)
		{
			var value = context.Contacts.Find(contact.Id);
			value.Image = contact.Image;
			value.Address = contact.Address;
			value.PhoneNumber = contact.PhoneNumber;
			value.Email = contact.Email;
			value.MapUrl = contact.MapUrl;
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public PartialViewResult PartialSocialMedia()
		{
			var values = context.SocialMedia.ToList();
			return PartialView(values);
		}

		public ActionResult DeleteSocialMedia(int id)
		{
			var value = context.SocialMedia.Find(id);
			context.SocialMedia.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}
		public ActionResult CreateSocialMedia()
		{
			return View();	
		}

		[HttpPost]
		public ActionResult CreateSocialMedia(SocialMedia socialMedia)

		{
			var value = context.SocialMedia.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public ActionResult UpdateSocialMedia(int id)
		{
			var value = context.SocialMedia.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			var value = context.SocialMedia.Find(socialMedia.Id);
			value.SocialMedianame = socialMedia.SocialMedianame;
			value.SocialMediaUrl = socialMedia.SocialMediaUrl;
			value.SocialMediaIcon = socialMedia.SocialMediaIcon;
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public PartialViewResult PartialAdmin()
		{
			var values = context.Admins.ToList();
			return PartialView(values);
		}

		public ActionResult UpdateAdmin(int id)
		{
			var value = context.Admins.Find(id);
			return View(value);
		}

		[HttpPost]
		public ActionResult UpdateAdmin(BurgerMenuProject.Entities.Admin admin)
		{
			var value = context.Admins.Find(admin.AdminId);
			value.Username = admin.Username;
			value.Password = admin.Password;
			value.Email = admin.Email;
			value.Name = admin.Name;
			value.Surname = admin.Surname;
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public ActionResult DeleteAdmin(int id)
		{
			var value =context.Admins.Find(id);
			context.Admins.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}

		public ActionResult CreateAdmin()
		{
			return View();
		}

		[HttpPost]
		public ActionResult CreateAdmin(BurgerMenuProject.Entities.Admin admin)
		{
			context.Admins.Add(admin);
			context.SaveChanges();
			return RedirectToAction("Index", "Settings");
		}
	}
}