<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="RegisterPage" %>
<asp:Content ID="c1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Register</h1>

    <asp:ValidationSummary ID="vs" runat="server" CssClass="val-summary" HeaderText="Please fix the following:" />

    <div class="form-row">
        <label>Name</label>
        <asp:TextBox ID="txtName" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtName" runat="server" ErrorMessage="Name required" Display="Dynamic" />
    </div>

    <div class="form-row">
        <label>Email</label>
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RequiredFieldValidator ControlToValidate="txtEmail" runat="server" ErrorMessage="Email required" Display="Dynamic" />
        <asp:RegularExpressionValidator ControlToValidate="txtEmail" runat="server"
            ErrorMessage="Invalid email" ValidationExpression="^\S+@\S+\.\S+$" Display="Dynamic" />
    </div>

    <div class="form-row">
        <label>Ticket Type</label>
        <asp:RadioButtonList ID="rblTicket" runat="server">
            <asp:ListItem Text="Standard" Value="Standard" Selected="True" />
            <asp:ListItem Text="VIP" Value="VIP" />
        </asp:RadioButtonList>
    </div>

    <div class="form-row">
        <label>City</label>
        <asp:DropDownList ID="ddlCity" runat="server">
            <asp:ListItem Text="Select..." Value="" />
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Pune</asp:ListItem>
            <asp:ListItem>Bengaluru</asp:ListItem>
            <asp:ListItem>Delhi</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ControlToValidate="ddlCity" InitialValue="" runat="server" ErrorMessage="City required" Display="Dynamic" />
    </div>

    <div class="form-row">
        <asp:CheckBox ID="chkTerms" runat="server" Text="I agree to the Terms" />
        <asp:CustomValidator ID="cvTerms" runat="server" ErrorMessage="You must agree to Terms"
            OnServerValidate="cvTerms_ServerValidate" Display="Dynamic" />
    </div>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit Registration" OnClick="btnSubmit_Click" />
</asp:Content>
