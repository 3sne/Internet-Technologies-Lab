<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q3 ~ Shopping Cart</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .begone {
            display: none;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row m-5 justify-content-center">
            <div class="card shadow" style="width: 25em;">
                <div class="card-body">
                    <h4 class="card-title">Q3 ~ Shopping Cart</h4>
                    <form id="form1" runat="server">
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label2" runat="server" Text="Customer Name"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="name_tb" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label3" runat="server" Text="Item 1: "></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="i1" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label4" runat="server" Text="Item 2: "></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="i2" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label5" runat="server" Text="Item 3: "></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="i3" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button CssClass="btn btn-dark" ID="Button1" runat="server" Text="Save Cart" OnClick="Button1_Click" />
                    </form>
                </div>
            </div>
        </div>
        <div id="status_jumbo" class="jumbotron" runat="server">
            <h3>Cart Saved! <a href="index.aspx" target="_blank">Open this page in new tab to see the cart data persist!</a></h3>
        </div>
    </div>
    <script src="ext/js/jquery-3.4.1.min.js"></script>
    <script src="ext/js/popper.min.js"></script>
    <script src="ext/js/bootstrap.min.js"></script>
</body>
</html>
