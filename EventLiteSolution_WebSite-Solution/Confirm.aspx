<%@ Page Title="Confirm" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="ConfirmPage" %>
<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Thank you, <asp:Label ID="lblName" runat="server" />!</h1>
    <p>Your registration has been received.</p>
    <p>Total registrations today: <asp:Label ID="lblTotal" runat="server" /></p>
    <p><a href="Home.aspx">Back to events</a></p>
</asp:Content>
