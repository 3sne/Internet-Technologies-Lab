<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Phone Selection</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_leftPane" Runat="Server">
    <p class="text-muted">No Phone Selected</p>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder_mainContent" Runat="Server">
    <asp:DropDownList ID="ddl1" OnSelectedIndexChanged="ddl1_SelectedIndexChanged" runat="server"></asp:DropDownList>
</asp:Content>

