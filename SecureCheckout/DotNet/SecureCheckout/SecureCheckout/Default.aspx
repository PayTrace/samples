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
    <asp:Panel ID="pnl_response" runat="server" Visible="false">
        <fieldset >
        <legend>Response:</legend>

            <p>Parameters: <asp:Label runat="server" ID="lblResponce" /></p>

            <p>Order ID: <asp:Label runat="server" ID="lblOrderID" /></p>
            <p>Auth Key: <asp:Label runat="server" ID="lblAUTHKEY" /></p>

            <asp:HyperLink runat="server" ID="lnkSendToBilling" Text="Send to billing page."  />
        </fieldset>
    </asp:Panel>
</asp:Content>
