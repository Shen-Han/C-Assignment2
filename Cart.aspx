<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShopCart1.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Halloween Cart</title>

    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <link href="Content/site.css" rel="stylesheet" />
</head>

<body>
<div class="container">
    <header class="jumbotron"><!-- image set in site.css --></header>
    <main>
        <form id="form1" runat="server" class="form-horizontal">
    
            <div class="row"><!-- row 1 -->
                <div class="col-sm-12"><h1>Your shopping cart</h1></div>
                <div class="col-sm-6"><!-- cart display column -->
                    <div class="form-group">
                        <div class="col-sm-12"><asp:ListBox ID="lstCart" runat="server" CssClass="form-control"></asp:ListBox></div>
                    </div>
                </div>
                <div class="col-sm-6"><!-- cart edit buttons column -->
                    <div class="form-group">
                        <div class="col-sm-12"><asp:Button ID="btnRemove" runat="server" 
                            Text="Remove Item" CssClass="btn btn-outline-primary"  /></div>
                        <div class="col-sm-12"><asp:Button ID="btnEmpty" runat="server" 
                            Text="Empty Cart" CssClass="btn btn-outline-primary"  /></div>
                    </div>
                </div>
            </div><!-- end of row 1 -->

            <div class="row"><!-- row 2 -->
                <div class="col-sm-12">
                    <div class="form-group"><!-- message label -->
                        <asp:Label ID="lblMessage" runat="server" EnableViewState="False"
                            CssClass="text-info col-sm-12"></asp:Label>
                    </div>
                    <div class="form-group"><!-- buttons -->
                        <div class="col-sm-12">
                            <asp:Button ID="btnContinue" runat="server" Text="Continue Shopping" CssClass="btn btn-outline-primary" PostBackUrl="~/Order.aspx" />
                            <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" CssClass="btn btn-outline-primary"  />
                        </div>
                    </div>
                </div>
            </div><!-- end of row 2 -->

        </form>
    </main>
</div>
</body>
</html>
