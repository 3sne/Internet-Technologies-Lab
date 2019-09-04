<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Captcha.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q4 - Captcha</title>
    <style>
        #real_cepcha {
            font-family: Consolas;
        }
    </style>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet"/>
</head>
<body>
    <div class="container">
        <div class="row m-5 justify-content-center">
            <div class="card shadow" style="width: 25em;">
                <div class="card-body">
                    <h4 class="card-title text-center">Q4 - Captcha</h4>
                    <hr />
                    <form id="form1" runat="server">
                        <div class="form-group text-center">
                            <div class="card">
                                <div class="card-body">
                                    <p class="display-4" id="real_cepcha" runat="server"></p>
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="What do you see above?"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="ni_tb" runat="server"></asp:TextBox>
                        </div>
                        <div class="text-center">
                            <asp:Button CssClass="btn btn-dark" ID="btn_verify" runat="server" Text="Verify" OnClick="btn_verify_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>

        <div class="jumbotron text-center" id="jmb" runat="server">
            <p class="h3" id="status" runat="server"></p>
        </div>

    </div>
    <script type="text/javascript" src="ext/js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="ext/js/popper.min.js"></script>
    <script type="text/javascript" src="ext/js/bootstrap.min.js"></script>
</body>

</html>
