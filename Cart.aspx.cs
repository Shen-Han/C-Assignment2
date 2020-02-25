using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//access this projects model folder                                
using ShopCart1.Models;
using System.Data;


namespace ShopCart1
{
    public partial class Cart : System.Web.UI.Page
    {
        private Cartitem myCartItem;
        
        //private Cartitem itempass;
    
        protected void Page_Load(object sender, EventArgs e)
        {
            //how can I receive information from btnAdd_Click from order page          
            //Page lastPage = (Page)Context.Handler;
           
            
            myCartItem = (Cartitem)Session["Cartitem"];
            //Validate that there are items within the cart
            if (myCartItem != null)
            {
                //write out what is being purchased
                lstCart.Items.Add(myCartItem.Display());
                string itemString = "Purchasing" + myCartItem.Quantity.ToString() + "" + myCartItem.Product.Name;
                lstCart.Items.Add(itemString);
            }
            else { lstCart.Items.Add("Please add an item into the cart."); }
        }

        /*private void BindCartProducts()
        {
            Cartitem myCartItem = new Cartitem(selectedProduct, Convert.ToInt32(txtQuantity.Text));

        }
        */
        

    }

}