using Microsoft.AspNetCore.Mvc;
using myapp.Models;

namespace myapp.Controllers
{
	public class ItemsController : Controller
	{
		// GET: ItemsController
		public ActionResult Overview()
		{
			var item = new Item() { Name = "keyboard" };
			return View(item);
		}

		public ActionResult Edit(int id)
		{
			return Content("id= " + id);
		}
	}
}
