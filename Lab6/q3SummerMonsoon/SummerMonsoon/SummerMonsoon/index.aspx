<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" Theme="Monsoon" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row justify-content-center p-5">
                <p id="theme_announce" class="display-2" runat="server"></p>
            </div>
            <div class="row justify-content-center">
                <asp:Button ID="toggle_btn" Text="Toggle Theme ~" runat="server" OnClick="toggle_btn_Click"/>
            </div>
        </div>
    </form>
    <script src="ext/js/jquery-3.4.1.min.js"></script>
    <script src="ext/js/popper.min.js"></script>
    <script src="ext/js/bootstrap.min.js"></script>
</body>
</html>

