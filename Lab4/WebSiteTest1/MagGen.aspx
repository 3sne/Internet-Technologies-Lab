<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MagGen.aspx.cs" Inherits="MagGen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="ffamLabel" runat="server" Text="Select Font Family: "></asp:Label>
            <asp:DropDownList ID="ffamDDL" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="fsizeLabel" runat="server" Text="Select Font Size: "></asp:Label>
            <asp:DropDownList ID="fsizeDDL" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="bgLabel" runat="server" Text="Select Background: "></asp:Label>
            <asp:DropDownList ID="bgDDL" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Label ID="textLabel" runat="server" Text="Enter Title: "></asp:Label>
            <asp:TextBox ID="textInput" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="descLabel" runat="server" Text="Enter Description: "></asp:Label>
            <asp:TextBox ID="descTB" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="descFontSizeLabel" runat="server" Text="Select Font Size: "></asp:Label>
            <asp:DropDownList ID="descFSDLL" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button 
                ID="submitButton" 
                runat="server" 
                Text="Generate!"
                OnClick="submitButton_Click"/>
        </div>
        <div id="answer" class="Answer" runat="server">
            
        </div>
    </form>
</body>
</html>
