<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Bill_Generator.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AQ2 ~ Bill Generator</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <div class="row m-5 justify-content-center">
            <div class="card shadow" style="min-width: 25em;">
                <div class="card-body">
                    <h4 class="card-title">AQ2 ~ Bill Generator</h4>
                    <hr />
                    <form id="form1" runat="server">
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label2" runat="server" Text="Manufacturer"></asp:Label>
                            <asp:DropDownList ID="manuf_ddl" runat="server"></asp:DropDownList>
                        </div>
                        <hr />
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label4" runat="server" Text="Device Type"></asp:Label>
                            <asp:RadioButtonList ID="dev_type_cbl" runat="server"></asp:RadioButtonList>
                        </div>
                        <hr />
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="Rate"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="rate_tb" runat="server"></asp:TextBox>
                        </div>
                        <hr />
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label3" runat="server" Text="Quantity"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="quantity_tb" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button CssClass="btn btn-dark" ID="btn_make_bill" runat="server" Text="Make Bill" OnClick="btn_make_bill_Click" />
                    </form>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
