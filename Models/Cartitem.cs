using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart1.Models
{
    public class Cartitem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public Cartitem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
    }
}