using BurgerMenuProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using BurgerMenuProject.Entities;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        // GET: Admin/Message

        BurgerMenuContext context = new BurgerMenuContext();

        public ActionResult Inbox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverEmail == email).ToList();
            return View(values);
        }

        public PartialViewResult PartialSendBox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderEmail == email).ToList();
            return PartialView(values);
        }

        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(BurgerMenuProject.Entities.Message message)
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            message.SenderEmail = email;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Inbox", "Message", new { area = "Admin" });
        }
    }
}