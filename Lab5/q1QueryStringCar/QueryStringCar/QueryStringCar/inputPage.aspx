<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inputPage.aspx.cs" Inherits="QueryStringCar.inputPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="ext/css/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
    <div class="row m-5 justify-content-center">
        <div class="card shadow" style="width: 24rem;">
            <div class="card-body">
                <h4 class="card-title">Q1 ~ Query String Demo</h4>
                <form id="form1" runat="server">
        <div class="form-group">
            <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="Manufacturer"></asp:Label>
            <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label CssClass="form-text" ID="Label2" runat="server" Text="Car Model"></asp:Label>
            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button CssClass="btn btn-dark" ID="Button1" runat="server" Text="Go!" OnClick="Button1_Click" />
    </form>
            </div>
        </div>
    </div>
</body>
</html>
