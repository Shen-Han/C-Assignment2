using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopCart1.Models;

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

        public string Display() {
            return "Purchasing" + Quantity + "X" + Product.Name + "at" + Product.UnitPrice + "each =" + Product.UnitPrice * Quantity;

        }
    }
}