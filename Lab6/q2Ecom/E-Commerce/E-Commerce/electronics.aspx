<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="electronics.aspx.cs" Inherits="electronics" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>Electronix</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row justify-content-center">
        <form id="dont" runat="server">
            <div class="form-group">
                <asp:Label CssClass="form-text" ID="Label1" runat="server" Text="Choose Category"></asp:Label>
                <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            </div>
        </form>
    </div>
    <div class="row justify-content-center">
        <div id="answers" runat="server">
            <div class="card" style="width: 18rem;">
                <div class="card-header">
                    Available Brands
                </div>
                <ul class="list-group list-group-flush" id="li_pool" runat="server">
                </ul>
            </div>
        </div>
    </div>
</asp:Content>

