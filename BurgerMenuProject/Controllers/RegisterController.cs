﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BurgerMenuProject.Entities;
using BurgerMenuProject.Context;
namespace BurgerMenuProject.Controllers
{
	[AllowAnonymous]
	public class RegisterController : Controller
    {
        // GET: Register
        BurgerMenuContext context= new BurgerMenuContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin admin)
        {
            context.Admins.Add(admin);  
            context.SaveChanges();  
            return RedirectToAction("Index", "Login");
        }
    }
}