<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showDetail.aspx.cs" Inherits="QueryStringCar.showDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div id="main" runat="server">

        </div>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Go back" />
    </form>
</body>
</html>
