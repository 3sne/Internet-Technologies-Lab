<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showDetail.aspx.cs" Inherits="QueryStringCar.showDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q1: Query String</title>
    <style>
        .container {
            text-align: center;
        }
        body {
            height: 100vh;
        }
     
    </style>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="row h-100 align-items-center justify-content-center">
        <div class="card shadow m-3">
            <div id="main" class="card-body" style="width:18rem" runat="server">
                <h5 class="card-title">Your Selection</h5>
                <h5 id="car_holder" class="card-text" runat="server"></h5>
                <asp:Button ID="Button1" CssClass="btn btn-dark m-1" runat="server" OnClick="Button1_Click" Text="Go back" />
            </div>
        </div>
    </div>
    </form>
    <script type="text/javascript" src="ext/js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="ext/js/popper.min.js"></script>
    <script type="text/javascript" src="ext/js/bootstrap.min.js"></script>
</body>
</html>
