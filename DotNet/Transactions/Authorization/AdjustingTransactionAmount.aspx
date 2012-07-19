<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdjustingTransactionAmount.aspx.cs" Inherits="Authorization.AdjustingTransactionAmount" %>
<%@ Register src="ResponseList.ascx" tagname="ResponseList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<h2>Adjust Transaction Amount</h2> 
<br />
<asp:Panel runat="server" ID="PanelSetAmount" >
<asp:Label ID="lbAmount" runat="server" AssociatedControlID="tbSetAmount" >Amount:</asp:Label><br />
<asp:TextBox runat="server" ID="tbSetAmount" CssClass="textEntry" Text="100.32" />
<asp:RegularExpressionValidator runat="server" ValidationExpression="[0-9]+(\.[0-9][0-9]?)?" ControlToValidate="tbSetAmount" Text="Must be a valid decimal value." CssClass="failureNotification" />
<br />
<br />
<asp:Button runat="server" Text="Create Authorization Amount" OnClick="OnCreateAuthorization_Click" />
</asp:Panel>
<br />
<asp:Panel runat="server" ID="PanelShowAdjustment" Visible="false" > 
    <uc1:ResponseList ID="ResponseList1" runat="server" />
    <br />
    <asp:Label runat="server" >Adjust Amount for Transaction ID: </asp:Label><asp:Label runat="server" ID="lblTransactionID" /><br /><br />
    <asp:Label runat="server" AssociatedControlID="tbChangeAmount" >Change Amount:</asp:Label><br />
    <asp:TextBox runat="server" ID="tbChangeAmount" CssClass="textEntry" />
    <asp:RegularExpressionValidator runat="server" ValidationExpression="[0-9]+(\.[0-9][0-9]?)?" ControlToValidate="tbChangeAmount"  CssClass="failureNotification" Text="Must be a decimal value"  />
    <br /><br />
    <asp:Button ID="BtnAdjustmentAmount" runat="server" Text="Adjust Authorization Amount" OnClick="OnAdjustTransactionAmount" />
</asp:Panel>
<uc1:ResponseList ID="ResponseList2" runat="server" />
</asp:Content>
