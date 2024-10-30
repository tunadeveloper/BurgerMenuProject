using BurgerMenuProject.Context;
using BurgerMenuProject.Entities;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace BurgerMenuProject.Areas.Admin.Controllers
{
	public class CategoryController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult CategoryList(int page = 1)
        {
            int pagesize = 7;
            var values = context.Categories
                .ToList()
                .ToPagedList(page,pagesize);

			ViewBag.TotalPages = values.PageCount;
			ViewBag.CurrentPage = page;
			return View(values);
        }

        public ActionResult CreateCategory()
        {
            return View();  
        }

        [HttpPost]
		public ActionResult CreateCategory(Category category)
		{
			context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList", "Category",new { areas = category });
		}

        public ActionResult DeleteCategory(int id)
        {
            var value = context.Categories.Find(id);
            context.Categories.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CategoryList");

        }

        public ActionResult UpdateCategory(int id)

        {
            var value = context.Categories.Find(id);
            return View(value);
        }
        [HttpPost]
		public ActionResult UpdateCategory(Category category)

		{
			var value = context.Categories.Find(category.CategoryId);
            value.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
		}
	}
}