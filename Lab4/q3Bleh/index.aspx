<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q3 ~ e-Card Generator</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="row">
            <div class="col-lg-6 offset-lg-3">
                <p class="h2 text-center m-3">
                    Q3 ~ e-Card Generator
                </p>
                <div class="card">
                    <div class="card-body">
                        <form id="form1" runat="server">
                            <div class="form-group">
                                <asp:Label CssClass="form-text" ID="ffamLabel" for="ffamDDL" runat="server" Text="Select Font Family: "></asp:Label>
                                <asp:DropDownList CssClass="form-control" ID="ffamDDL" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label CssClass="form-text" ID="fsizeLabel" runat="server" Text="Select Font Size: "></asp:Label>
                                <asp:DropDownList CssClass="form-control" ID="fsizeDDL" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label CssClass="form-text" ID="bgLabel" runat="server" Text="Select Background: "></asp:Label>
                                <asp:DropDownList CssClass="form-control" ID="bgDDL" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Label CssClass="form-text" ID="textLabel" runat="server" Text="Enter Title: "></asp:Label>
                                <asp:TextBox CssClass="form-control" ID="textInput" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label CssClass="form-text" ID="descLabel" runat="server" Text="Enter Description: "></asp:Label>
                                <asp:TextBox CssClass="form-control" ID="descTB" runat="server"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Label CssClass="form-text" ID="descFontSizeLabel" runat="server" Text="Select Font Size: "></asp:Label>
                                <asp:DropDownList CssClass="form-control" ID="descFSDLL" runat="server"></asp:DropDownList>
                            </div>
                            <div class="form-group">
                                <asp:Button CssClass="btn btn-primary" ID="submitButton" runat="server" Text="Generate!" OnClick="submitButton_Click"/>
                            </div>
                        </form>
                    </div>
                </div>
                <div class="m-5" id="answer" runat="server">

                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="ext/js/jquery-3.4.1.min.js"></script>
    <script type="text/javascript" src="ext/js/popper.min.js"></script>
    <script type="text/javascript" src="ext/js/bootstrap.min.js"></script>
</body>
</html>
