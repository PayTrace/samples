<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateCustomer.aspx.cs" Inherits="Authorization.CreateCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div style="width:100%">
    <h2 style="float:left;width:60%;">
        Create Customer 
    </h2>
    <div style="clear:both;float:right;margin:10px;">
        <asp:Button runat="server" ID="Top_btnSubmit" Text="Submit" OnClick="OnbtnSubmit" />
    </div>
    </div>
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
                     <asp:TextBox runat="server" ID="tbCustomerUserName" CssClass="textEntry" />
                    </p>
                    <p>
                        <label>Customer Password</label><br />
                        <asp:TextBox TextMode="Password" runat="server" ID="tbPassword"  CssClass="passwordEntry" />
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
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbExpirMonth"  CssClass="" MaxLength="2" Text="1" Width="10px"  />
                         <label> Experation Year:</label>
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbExpirYear"  CssClass="" MaxLength="4" Text="2015" Width="30px"   />
                    </p>
                    </fieldset>  
                </div>
                <div id="address" style="clear:both" > 
                <div style="float:left;width:42%;"> 
                <fieldset >
                <legend>Billing Address</legend>
                    <p>
                        <label>Full Name:</label><br />
                        <asp:TextBox runat="server" ID="tbBillingFullName" CssClass="textEntry" TextMode="SingleLine" Text="Bob Smith"/>
                    </p>
                    <p>
                        <label>Street:</label><br />
                        <asp:TextBox runat="server" ID="tbBillingStreet" CssClass="textEntry" TextMode="SingleLine" Text="1234 Happy Lane"/>
                    </p>
                    <p>
                        <label>Street 2:</label><br />
                     <asp:TextBox runat="server" ID="tbBillingStreet2" CssClass="textEntry" TextMode="SingleLine" />
                    </p>
                    <p>
                        <label>City:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbBillingCity"  CssClass="textEntry"  Text="Seattle"/>
                    </p>
                    <p>
                        <label>State / Region:</label><br />
                        <asp:TextBox TextMode=SingleLine runat="server" ID="tbBillingRegion"  CssClass="textEntry" Text="Washington" />
                    </p>
                    <p>
                        <label>Postal Code / Zip:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbBillingPostalCode"  CssClass="textEntry" Text="98104" />
                    </p>
                    <p>
                        <label>Country:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="TbBillingCountry"  CssClass="textEntry" Text="USA" />
                    </p>
                    
                    </fieldset>       
                </div>
                 <div style="float:right;width:42%;">              
                 <fieldset >
                 <legend>Shipping Address</legend>
                     <p>
                        <label>Full Name:</label><br />
                        <asp:TextBox runat="server" ID="tbShippingFullName" CssClass="textEntry" TextMode="SingleLine" Text="Bob Smith"/>
                    </p>
                    <p>
                        <label>Street:</label><br />
                     <asp:TextBox runat="server" ID="tbShippingStreet" CssClass="textEntry" TextMode="SingleLine" Text="1234 Happy Lane" />
                    </p>
                    <p>
                        <label>Street 2:</label><br />
                     <asp:TextBox runat="server" ID="tbShippingStreet2" CssClass="textEntry" TextMode="SingleLine" />
                    </p>
                    <p>
                        <label>City:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbShippingCity"  CssClass="textEntry" Text="Seattle" />
                    </p>
                    <p>
                        <label>State / Region:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbShippingRegion"  CssClass="textEntry" Text="Washington" />
                    </p>
                    <p>
                        <label>Postal Code / Zip:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbShippingPostalCode"  CssClass="textEntry" Text="98104"/>
                    </p>
                    <p>
                        <label>Country:</label><br />
                        <asp:TextBox TextMode="SingleLine" runat="server" ID="tbShippingCountry"  CssClass="textEntry" Text="USA" />
                    </p>
                    </fieldset>  
                    </div >
                        <div style="clear:both;float:right;margin:10px;"><asp:button runat="server" ID="bottom_btnSubmit" Text="Submit"  OnClick="OnbtnSubmit" /></div>
                    </div>
            
</asp:Content>
