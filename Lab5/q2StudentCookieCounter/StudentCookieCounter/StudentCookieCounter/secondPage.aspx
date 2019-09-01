<%@ Page Language="C#" AutoEventWireup="true" CodeFile="secondPage.aspx.cs" Inherits="secondPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
    <title>Q2 ~ Second Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row h-100 align-items-center justify-content-center">
            <div class="card shadow m-3">
                <div id="main" class="card-body" style="width: 18rem" runat="server">
                    <h4 class="card-title">Student Info</h4>
                    <p id="name_holder" class="card-text text-uppercase" runat="server"></p>
                    <p id="regno_holder" class="card-text" runat="server"></p>
                    <p id="subject_holder" class="card-text" runat="server"></p>
                    <div class="text-center">
                        Counter><span id="_counter_holder" runat="server">0</span>
                        <asp:Button CssClass="btn btn-dark" ID="Button1" runat="server" Text="Increment!" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
