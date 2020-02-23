using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//access this projects model folder                                
using ShopCart1.Models;


namespace ShopCart1
{
    public partial class Cart : System.Web.UI.Page
    {
        private Cartitem myCartItem;

        protected void Page_Load(object sender, EventArgs e)
        {
            myCartItem = (Cartitem)Session["Cartitem"];
            //validate that there are stuff in the cart
            if (myCartItem != null)
            {
                //write out what is being purchased.
                lstCart.Items.Add(myCartItem.Display());
                string itemString = "Purchasing" + myCartItem.Quantity.ToString() + "" + myCartItem.Product.Name;
                lstCart.Items.Add(itemString);
            }
        }

        /*private void BindCartProducts()
        {
            Cartitem myCartItem = new Cartitem(selectedProduct, Convert.ToInt32(txtQuantity.Text));

        }
        */
        

    }

}