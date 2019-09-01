<%@ Page Language="C#" AutoEventWireup="true" CodeFile="firstPage.aspx.cs" Inherits="firstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q2 ~ First Page</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="row m-5 justify-content-center">
        <div class="card shadow" style="width: 25em;">
            <div class="card-body">
                <h4 class="card-title">Q2 ~ Session & Cookie</h4>
                <form id="form1" runat="server">
                    <div class="form-group">
                        <asp:Label CssClass="form-text" ID="Label2" runat="server" Text="Name"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="name_tb" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="form-text" ID="Label3" runat="server" Text="Registration Number"></asp:Label>
                        <asp:TextBox CssClass="form-control" ID="regno_tb" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="Subjects"></asp:Label>
                        <asp:DropDownList CssClass="form-control" ID="sub_ddl" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button CssClass="btn btn-dark" ID="Button1" runat="server" Text="Go!" OnClick="Button1_Click" />
                </form>
            </div>
        </div>
    </div>
</body>
</html>
