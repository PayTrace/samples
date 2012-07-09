<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ResponseList.ascx.cs" Inherits="Authorization.ResponseList" %>
<asp:DataGrid runat="server" ID="ResponseGrid" BorderStyle="Solid" AutoGenerateColumns="false" HeaderStyle-CssClass="header" HeaderStyle-ForeColor="White"  >
<Columns>
<asp:BoundColumn DataField="Key"  HeaderText="Keys" /> 
<asp:BoundColumn DataField="Value" HeaderText="Values" />
</Columns>

</asp:DataGrid>
