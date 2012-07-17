<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdvancedAuthorization.aspx.cs" Inherits="Authorization.AdvancedAuthorization" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Advanced Authorization
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
    <p><asp:Label runat="server" ID="lblRaw" /></p>
        <p><asp:Button runat="server" id="btnSubmit" Text="Submit" OnClick="OnbtnSubmitClick"  /> 
        </p>
       <asp:Panel ID="pnlResponse" runat="server" Visible="false" >
       <table>
        <tr>
            <td>Response:</td>
            <td> <asp:Label runat="server" id="lblResponse" /></td>
        </tr>
        <tr>
            <td> TransactionID:</td>
            <td><asp:Label runat="server" id="lblTransactionID" /> </td>
        </tr>
        <tr>
            <td> Approval Code:</td>
            <td> <asp:Label runat="server" id="lblAppCode" /> </td>
        </tr>
        <tr>
            <td>Approval Message:</td>
            <td> <asp:Label runat="server" id="lblAppMessage" /> </td>
        </tr>
        <tr>
            <td>Address Verification System Response:</td>
            <td><asp:Label runat="server" id="lblAVSResponse" /></td>
        </tr>
        <tr>
            <td>CSCResponse:</td>
            <td> <asp:Label runat="server" id="lblCSCResponse" /></td>
        </tr>
       </table>
        
       </asp:Panel>
    </div>
</asp:Content>
