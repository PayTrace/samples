<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="Authorization.CreateCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create Customer
    </h2>
        <div style="float:left;width:42%;" >
            <fieldset>
            <legend>Customer Form</legend>
                <p>
                    <asp:Label ID="CustomerNameLabel" runat="server" AssociatedControlID="tbCustomerName">Customer Name:</asp:Label><br />
                    <asp:TextBox runat="server" ID="tbCustomerName" Text="John Doe" CssClass="textEntry" />
                </p>
                <p>
                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="tbEmail">Email:</asp:Label><br />
                    <asp:TextBox runat="server" ID="tbEmail"  Text="test@example.com" CssClass="textEntry" />
                </p>
                <p>
                    <asp:Label ID="PhoneLabel" runat="server" AssociatedControlID="tbPhone">Phone:</asp:Label><br />
                    <asp:TextBox runat="server" ID="tbPhone" Text="123-123-1234"  CssClass="textEntry"/>
                </p>
                <p>
                    <asp:Label ID="FaxLabel" runat="server" AssociatedControlID="tbFax">Fax:</asp:Label><br />
                    <asp:TextBox runat="server" ID="tbFax" CssClass="textEntry"  />
                </p>
            </fieldset>
            </div>
            <div style="float:right;width:42%;"> 
                <fieldset >
                <legend>Customer Login Info</legend>
                    <p>
                        <label>Customer User Name</label><br />
                     <asp:TextBox runat="server" ID="TextUserName" CssClass="textEntry" />
                    </p>
                    <p>
                        <label>Customer Password</label><br />
                        <asp:TextBox TextMode="Password" runat="server" ID="txtPwd"  CssClass="passwordEntry" />
                    </p>
                    </fieldset>       
                <fieldset >
                <legend>Customer Account Info</legend>
                    <p>
                        <label>Credit Card Number:</label><br />
                     <asp:TextBox runat="server" ID="TextBox1" CssClass="textEntry" Text="4111111111111111" />
                    </p>
                    <p>
                        <label> Experation Month:</label>
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbExperMonth"  CssClass="" MaxLength="2" Text="1" Width="10px"  />
                         <label> Experation Year:</label>
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbYear"  CssClass="" MaxLength="4" Text="2015" Width="30px"   />
                    </p>
                    </fieldset>  
                </div>       
            
</asp:Content>
