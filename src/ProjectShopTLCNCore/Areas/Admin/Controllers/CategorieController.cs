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
		[HttpPost("Admin/Categorie/Edit/{id}")]
		public IActionResult Edit(int id, Categories catego)
		{
			var categorie = db.Categories.SingleOrDefault(m=>m.CategoryId==id);

			categorie.CategoryName = catego.CategoryName;
			categorie.Description = catego.Description;
			categorie.DisplayOrder = catego.DisplayOrder;
			categorie.IsDisplay = catego.IsDisplay;
			categorie.Picture = catego.Picture;
			db.Categories.Update(categorie);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		// delete
		// POST: Movies/Delete/5

		[HttpGet("Admin/Categorie/Edit/{id}")]
		public async Task<IActionResult>Edit(int? id)
		{
			if (id ==null)
				return NotFound();
			var model = await db.Categories.SingleOrDefaultAsync(m => m.CategoryId == id);
			if (model == null)
				return NotFound();
			return View(model);
		}

		// POST: Cars/Delete/5
		// Delete an object via a POST request
		[ActionName("Delete")]
		[HttpGet("Admin/Categorie/Delete/{id}")]
		public IActionResult Delete(int? id)
		{
			var model = db.Categories.SingleOrDefault(m => m.CategoryId == id);
			// Remove the car from the collection and save changes
			db.Categories.Remove(model);
			db.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}