<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SilentPostResponse.Default" %>

<%@ Register assembly="System.Web.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" namespace="System.Web.UI.WebControls" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Silent Post Results</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
	<h3>List of Silent Posts</h3>
        <asp:GridView ID="PostList" runat="server" DataSourceID="EntityDataSource1" AutoGenerateColumns="true" 
            EnableModelValidation="True" >
        </asp:GridView>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" 
            ConnectionString="name=PostModelEntities" 
            DefaultContainerName="PostModelEntities" EntitySetName="Posts">
        </asp:EntityDataSource>
    </div>
    </form>
</body>
</html>
