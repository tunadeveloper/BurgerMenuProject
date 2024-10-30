using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using PagedList;
namespace BurgerMenuProject.Areas.Admin.Controllers
{
   
    public class ProductController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
       
        public ActionResult ProductList(int page = 1)
        {
			int pageSize = 7;
			var values = context.Products
				.ToList()
				.ToPagedList(page, pageSize);

			ViewBag.TotalPages = values.PageCount;
			ViewBag.CurrentPage = page;
			return View(values);
        }

        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public ActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {

            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;

            var value = context.Products.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value = context.Products.Find(product.ProductId);
            value.ProductName = product.ProductName;
            value.ImageUrl = product.ImageUrl;
            value.Description = product.Description;
            value.Price = product.Price;
            value.CategoryId = product.CategoryId;
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        public ActionResult CategoryProducts(int id)

        {
            var value = context.Products.Where(y=>y.CategoryId == id).ToList();
            return View(value); 
        }

        public ActionResult DealOfTheDayToFalse(int id)
        {
            var value = context.Products.Where(x=>x.ProductId == id).FirstOrDefault();
            value.DealofTheDay = false;
            context.SaveChanges();
            return RedirectToAction("ProductList", "Product");
        }

		public ActionResult DealOfTheDayToTrue(int id)
		{
			var value = context.Products.Where(x => x.ProductId == id).FirstOrDefault();
			value.DealofTheDay = true;
			context.SaveChanges();
			return RedirectToAction("ProductList", "Product");
		}
	}

}