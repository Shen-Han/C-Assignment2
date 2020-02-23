using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopCart1.Models
{
    public class CartitemList
    {
        private List<Cartitem> cartItems;

        public CartitemList() {
            cartItems = new List<Cartitem>();
        }

        public void AddItem(Product product, int quantity) {
            Cartitem myCartItem = new Cartitem(product, quantity);
            cartItems.Add(myCartItem);
        }
    }
}