<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title>Information</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder_leftPane" Runat="Server">
    
        <p id="lp_ans" class="text-muted" runat="server"></p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder_mainContent" Runat="Server">
    <div class="card">
        <div class="card-body">
            <p class="card-title text-center" id="pname" runat="server"></p>
            <p><span class="h4">Battery:</span> <span id="pbattery" runat="server"></span></p>
            <p><span class="h4">Screen:</span> <span id="pscreen" runat="server"></span></p>
        </div>
    </div>
</asp:Content>