<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inputPage.aspx.cs" Inherits="QueryStringCar.inputPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Manufacturer"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Car Model"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Go!" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
