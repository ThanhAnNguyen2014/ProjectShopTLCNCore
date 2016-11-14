using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectShopTLCNCore.Models;
using Microsoft.EntityFrameworkCore;

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
		public async Task< IActionResult> Index()
		{
			return View(await db.Categories.ToListAsync());

		}
		[HttpGet]
		public IActionResult Create()
		{
			return View("Index");
		}
		[HttpPost]
		public IActionResult Create(Categories categorie)
		{
			db.Categories.Add(categorie);
			db.SaveChanges();
			return View();
		}
		public IActionResult Edit(int? id)
		{
			return View();
		}
		public async Task<IActionResult> Details(int id)
		{
			//if (id == null)
			//	return NotFound();
			var model = await db.Categories.SingleOrDefaultAsync(m => m.CategoryId == id);
			//if (model == null)
			//	return NotFound();

			return View(model); 
		}
	}
}