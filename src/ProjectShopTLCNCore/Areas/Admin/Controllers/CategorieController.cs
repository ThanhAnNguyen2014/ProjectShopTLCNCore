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
		[HttpGet]
		public async Task< IActionResult> Index()
		{
			return View(await db.Categories.ToListAsync());

		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Categories categorie)
		{
			
				db.Categories.Add(categorie);
				db.SaveChanges();
			
					
			return View(categorie);
		}
		public IActionResult Edit(int? id)
		{
			return View();
		}
		// delete
		// POST: Movies/Delete/5
		[HttpDelete]
		public async Task<IActionResult> Delete(int CategoryId)
		{
			var model = await db.Categories.FirstOrDefaultAsync(m=>m.CategoryId== CategoryId);
			db.Categories.Remove(model);
			await db.SaveChangesAsync();
			return RedirectToAction("Index");
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