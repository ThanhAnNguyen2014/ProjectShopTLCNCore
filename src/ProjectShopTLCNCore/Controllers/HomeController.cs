using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProjectShopTLCNCore.modelUser.Cart;

namespace ProjectShopTLCNCore.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			
			return View();
		}

		//public List<CartLine> GetCart()
		//{

		//	List<CartLine> listCart = HttpContext.Session.GetString("Cart") as List<CartLine>;
		//	if (listCart == null)
		//	{
		//		Khoi tao gio hang moi
		//	   listCart = new List<CartLine>();
		//		HttpContext.Session.GetString("Cart") = listCart;
		//	}
		//	return listCart;
		//}
	}
      
}
