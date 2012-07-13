<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ResponseList.ascx.cs" Inherits="Authorization.ResponseList" %>

<h2><asp:Label runat="server" ID="lblTitle" ></asp:Label></h2>
<asp:DataGrid runat="server" ID="ResponseGrid" BorderStyle="Solid" AutoGenerateColumns="false" HeaderStyle-CssClass="header" HeaderStyle-ForeColor="White" Visible="false"  >
<Columns>
<asp:BoundColumn DataField="Key"  HeaderText="Keys" /> 
<asp:BoundColumn DataField="Value" HeaderText="Values" />
</Columns>
</asp:DataGrid>

<asp:Label ID="lblShowErrorMessage" runat="server"  Visible="false" />
