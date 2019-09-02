<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q4 ~ Login Page</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet"/>
    <style>
        #jmb {
            transition: all 0.4s;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row m-5 justify-content-center">
            <div class="card shadow" style="width: 25em;">
                <div class="card-body">
                    <h4 class="card-title text-center">Q4 ~ Login Page</h4>
                    <hr />
                    <form id="form1" runat="server">
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label2" runat="server" Text="Username"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="name_tb" runat="server"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="pw_tb" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="text-center">
                            <asp:Button CssClass="btn btn-dark" ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click"/>
                        </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="jumbotron" id="jmb">
            <div class="text-center">
                <p class="h5">Don't Fail more than thrice!</p>
            </div>
            <hr />
            <div class="row">
                <div class="col-6 text-center">
                    <p class="h3 text-uppercase">Successes</p>
                    <strong id="_success_count_holder" class="display-4" runat="server">-</strong>
                </div>
                <div class="col-6 text-center">
                    <p class="h3 text-uppercase">Failures</p>
                    <strong id="_failure_count_holder" class="display-4" runat="server">-</strong>
                </div>
            </div>
            <div class="text-center">
                <strong class="h2 text-uppercase" id="derogation_handler" runat="server"></strong>
            </div>
        </div>
    </div>
    <script src="ext/js/jquery-3.4.1.min.js"></script>
    <script src="ext/js/popper.min.js"></script>
    <script src="ext/js/bootstrap.min.js"></script>
</body>
</html>
