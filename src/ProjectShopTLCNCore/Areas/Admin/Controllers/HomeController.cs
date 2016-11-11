using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectShopTLCNCore.Models;

namespace ProjectShopTLCNCore.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class HomeController : Controller
    {
		// GET: /<controller>/
		public IActionResult Index()
		{
			return View();
		}
	}
}