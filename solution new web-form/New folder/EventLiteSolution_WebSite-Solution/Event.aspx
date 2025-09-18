<%@ Page Title="Event" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Event.aspx.cs" Inherits="EventPage" %>
<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="hfNonce" runat="server" />
    <h1><asp:Label ID="lblTitle" runat="server" /></h1>
    <p><strong>Date:</strong> <asp:Label ID="lblDate" runat="server" /></p>
    <p><strong>Fee:</strong> <asp:Label ID="lblFee" runat="server" /></p>
    <p><asp:Label ID="lblDesc" runat="server" /></p>

    <div class="seats">
        <asp:Label ID="lblSeats" runat="server" Text="Seats: 1" />
        <asp:Button ID="btnMinus" runat="server" Text="-" OnClick="btnMinus_Click" />
        <asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" />
    </div>

    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
</asp:Content>
