<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AuthorizationAndSale.aspx.cs" Inherits="Authorization.AuthorizationAndSale" %>
<%@ Register src="ResponseList.ascx" tagname="ResponseList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Authorization and Sale
    </h2>
    <div style="float:left;">
        <p>CC: 4111111111111111</p>
        <p>Amount: $1.00</p>
        <p>Transaction Type: Authorization </p>
        <p>CSC: 999</p>
        <p>Expires: 01/2015</p>
    </div>

    <div style="float:left; padding-left:30px">
        <p>Street: 1234 happy lane</p>
        <p>City: Seattle</p>
        <p>Region: WA</p>
        <p>Postal: Code: 98136</p>
        <p>Country: USA</p>
    </div>
    <div style="clear:both">
     <p><asp:Button runat="server" id="btnSubmit" Text="Submit" OnClick="OnbtnSubmitClick"  /> </p>
        <uc1:ResponseList ID="ResponseList1" runat="server" />
        <uc1:ResponseList ID="ResponseList2" runat="server" />
    </div>
</asp:Content>
