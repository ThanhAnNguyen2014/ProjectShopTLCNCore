using System;
using System.Collections.Generic;

namespace ProjectShopTLCNCore.Models
{
    public partial class Products
    {
        public Products()
        {
            OrderDetails = new HashSet<OrderDetails>();
            Rating = new HashSet<Rating>();
            WishList = new HashSet<WishList>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public short ReorderLevel { get; set; }
        public decimal Discount { get; set; }
        public bool Discontinued { get; set; }
        public string Note { get; set; }
        public string Picture { get; set; }
        public bool IsNew { get; set; }
        public bool IsDelete { get; set; }
        public double AvgRating { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<WishList> WishList { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Suppliers Supplier { get; set; }
    }
}
