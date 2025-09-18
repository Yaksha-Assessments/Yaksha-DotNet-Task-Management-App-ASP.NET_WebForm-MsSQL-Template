<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>
<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Upcoming Events</h1>
    <asp:GridView ID="gvEvents" runat="server" AutoGenerateColumns="False" CssClass="grid">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Date" HeaderText="Date" DataFormatString="{0:dd-MMM-yyyy}" />
            <asp:BoundField DataField="Fee" HeaderText="Fee" DataFormatString="{0:C}" />
            <asp:HyperLinkField Text="View" DataNavigateUrlFields="Id" DataNavigateUrlFormatString="Event.aspx?eventId={0}" />
        </Columns>
    </asp:GridView>
</asp:Content>
