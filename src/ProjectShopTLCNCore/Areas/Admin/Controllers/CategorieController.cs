using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectShopTLCNCore.Models;

namespace ProjectShopTLCNCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CategorieController : Controller
    {
		ProjectShopAPIContext db;
		public CategorieController(ProjectShopAPIContext _db)
		{
			db = _db;
		}
		public IActionResult Index()
		{
			return View(db.Categories.ToList());

			//var model = new CategoriesDao();
			//return View(model.ListAll());
		}
	}
}