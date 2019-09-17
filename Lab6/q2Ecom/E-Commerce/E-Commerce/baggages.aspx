<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="baggages.aspx.cs" Inherits="baggages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row justify-content-center">
        <div class="card-deck">
            <div class="card">
                <div class="card-body">
                    <div class="card-img">
                        <img height="250" width="250" src="assets/img/laptop-bag.png" />
                    </div>
                    <p class="card-title h3 text-center">Laptop Bags</p>
                </div>
            </div>
            <div class="card">
                <div class="card-body">
                    <div class="card-img">
                        <img height="250" width="250" src="assets/img/trolley-bag.png" />
                    </div>
                    <p class="card-title h3 text-center">Trolley Bags</p>
                </div>
            </div>
            <div class="card">
                <div class="card-body">
                    <div class="card-img">
                        <img height="250" width="250" src="assets/img/backpack.png" />
                    </div>
                    <p class="card-title h3 text-center">Backpacks</p>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

