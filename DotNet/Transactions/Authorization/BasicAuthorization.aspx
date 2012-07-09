<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasicAuthorization.aspx.cs" Inherits="Authorization.BasicAuthorization" %>
<%@ Register src="ResponseList.ascx" tagname="ResponseList" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Basic Authorization
    </h2>

    <p><asp:Label runat="server" ID="lblRaw" /></p>
    <p><asp:Button runat="server" id="btnSubmit" Text="Submit" OnClick="OnbtnSubmitClick"  /> </p>
    <uc1:ResponseList ID="ResponseList" runat="server" />

</asp:Content>
