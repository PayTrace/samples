<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SecureCheckout._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
       Creating and Validating an Order
    </h2>
    <p>
          <asp:Button runat="server" ID="btnStartOrder" Text=" click to start order" OnClick="btnStartOrder_OnClick" />
    </p>

    <p><asp:Label runat="server" ID="lbl_responce" /></p>
</asp:Content>
