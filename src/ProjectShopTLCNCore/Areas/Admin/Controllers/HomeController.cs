using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectShopTLCNCore.Models;
using ProjectShopTLCNCore.Areas.Admin.Model;
using Microsoft.AspNetCore.Http;

namespace ProjectShopTLCNCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
    {
		private readonly ProjectShopAPIContext _context;

		public HomeController(ProjectShopAPIContext context)
		{
			_context = context;
		}
		// GET: /<controller>/
		public IActionResult Index()
		{
			if(HttpContext.Session.GetString("UserID") != null && HttpContext.Session.GetString("Email")!=null)
			{
				return View();
			}
			return RedirectToAction("Index","Login");
		}
	}
}