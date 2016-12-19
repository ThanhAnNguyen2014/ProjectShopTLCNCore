using ProjectShopTLCNCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectShopTLCNCore.modelUser.Cart
{
    public class CartLine
    {
		public int CartLineID { get; set; }
		public Products Product { get; set; }
		public int Quantity { get; set; }
    }
}
