using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShopCart1.Models;
using System.Data;

namespace ShopCart1
{
    public partial class Order : System.Web.UI.Page
    {
        private Product selectedProduct;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DropDownList1.DataBind();
            }
            selectedProduct = this.GetSelectedProduct();

            lblName.Text = selectedProduct.Name;
            lblShortDescription.Text = selectedProduct.ShortDescription;
            lblUnitPrice.Text = selectedProduct.LongDescription;
            lblName.Text = selectedProduct.UnitPrice.ToString("c") + " each";
            imgProduct.ImageUrl = "Images/Products/" + selectedProduct.ImageFile;
        }

        private Product GetSelectedProduct()
        {
            DataView productsTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            productsTable.RowFilter = string.Format("ProductID = '{0}'", DropDownList1.SelectedValue);
            DataRowView row = productsTable[0];

            Product p = new Product();
            p.Name = row["Name"].ToString();
            p.ShortDescription = row["ShortDescription"].ToString();
            p.LongDescription = row["LongDescription"].ToString();
            p.UnitPrice = (decimal)row["UnitPrice"];
            p.ImageFile = row["ImageFile"].ToString();

            return p;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Cartitem myCartItem = new Cartitem(selectedProduct, Convert.ToInt32(txtQuantity.Text));
            lblTotal.Text = "Purchasing " + myCartItem.Quantity + " " + myCartItem.Product.Name;
            Session["CartItem"] = myCartItem;

            //pass this to cart aspxcs
            //Server.Transfer("Cart.aspx.cs");
            
        }
    }
}