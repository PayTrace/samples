<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AuthorizeThenVoidTransaction.aspx.cs" Inherits="Authorization.AuthorizeThenVoidTransaction" %>
<%@ Register src="ResponseList.ascx" tagname="ResponseList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>
        Authorize Then Void
    </h2>
    <div>
        <p>CC: 4111111111111111</p>
        <p>Amount: $1.00</p>
        <p>Transaction Type: Authorization </p>
        <p>CSC: 999</p>
        <p>Expires: 01/2015</p>
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
            <td> AppCode:</td>
            <td> <asp:Label runat="server" id="lblAppCode" /> </td>
        </tr>
        <tr>
            <td>AppMessage:</td>
            <td> <asp:Label runat="server" id="lblAppMessage" /> </td>
        </tr>
        <tr>
            <td>AVSResponse:</td>
            <td><asp:Label runat="server" id="lblAVSResponse" /></td>
        </tr>
        <tr>
            <td>CSCResponse:</td>
            <td> <asp:Label runat="server" id="lblCSCResponse" /></td>
        </tr>
       </table>
        
         <p><asp:Button runat="server" id="btnVoid" Text="Void Authorization" OnClick="OnbtnVoidClick"  /> 

        </asp:Panel>
       
       <uc1:ResponseList ID="VoidResponseList" runat="server" />
 
    </div>

</asp:Content>
