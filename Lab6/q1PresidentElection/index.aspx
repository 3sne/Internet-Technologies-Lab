<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Q1 ~ Student Election</title>
    <link href="ext/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .begone {
            display: none;
        }
    </style>
</head>
<body>
    <div class="container">
        <div class="row m-5 justify-content-center">
            <div class="card shadow" style="width: 25em;">
                <div class="card-body">
                    <h4 class="card-title text-center">Student Election Simulator</h4>
                    <hr />
                    <form id="form1" runat="server">
                        <div id="summary_holder" class="d-flex justify-content-center" runat="server">
                            <div class="card">
                                <div class="card-body">
                                    <asp:ValidationSummary CssClass="text-danger" ID="val_summary" runat="server" DisplayMode = "List" ShowSummary = "true" HeaderText="Please Resolve following errors!" />
                                </div>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="Choose Candidate"></asp:Label>
                            <asp:DropDownList CssClass="form-control" ID="ddl_can" runat="server"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddl_can" runat="server" Display="None" ErrorMessage="Must select a candidate." />
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label6" runat="server" Text="Your House is"></asp:Label>
                            <asp:RadioButtonList ID="radio_house" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="radio_house" runat="server" Display="None" ErrorMessage="Must select a house."></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label7" runat="server" Text="Class"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="tb_class" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tb_class" runat="server" Display="None" ErrorMessage="Class: Cannot be empty."></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator1" ControlToValidate="tb_class" runat="server" Display="None" ErrorMessage="Class: Should be between 6 and 12." Type="Integer" MinimumValue="6" MaximumValue="12"/>
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label2" runat="server" Text="Gimme Email-ID"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="tb_email" runat="server" OnTextChanged="tb_email_TextChanged"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tb_email" runat="server" Display="None" ErrorMessage="Email: Cannot be empty."></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="regex_email" ControlToValidate="tb_email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" runat="server" Display="None" ErrorMessage="Email: Please enter valid email." />
                        </div>
                        <div class="form-group">
                            <asp:Label CssClass="form-text" ID="Label8" runat="server" Text="Your Parent's Phone Number"></asp:Label>
                            <asp:TextBox CssClass="form-control" ID="tb_phone" runat="server"></asp:TextBox>
                            <asp:CustomValidator ID="CustomValidator1" ControlToValidate="tb_phone" OnServerValidate="CustomValidator1_ServerValidate" runat="server" ErrorMessage="Galat numbar"></asp:CustomValidator>
                        </div>
                        <div class="text-center">
                            <asp:Button CssClass="btn btn-dark btn-lg" ID="Button1" runat="server" Text="Elect" OnClick="Button1_Click" />
                        </div>
                    </form>
                </div>
            </div>
        </div>
        <div id="status_jumbo" class="jumbotron text-center text-success" runat="server">
            <h3>Your choice was noted.</h3>
        </div>
    </div>
    <script src="ext/js/jquery-3.4.1.min.js"></script>
    <script src="ext/js/popper.min.js"></script>
    <script src="ext/js/bootstrap.min.js"></script>
</body>
</html>
