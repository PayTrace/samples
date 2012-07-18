using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    public class Keys
    {

        /// <summary>
        /// Any tax generated from freight or other services associated with the transaction.
        /// </summary>   
        public static string ADDTAX
        {
            get { return "ADDTAX"; }
        }

        /// <summary>
        /// A flag used to indicate where additional tax was included in
        ///this transaction. Set to Y if additional tax was included
        ///and N if no additional tax was applied.
        /// </summary>   
        public static string ADDTAXIND
        {
            get { return "ADDTAXIND"; }
        }

        /// <summary>
        /// Descriptor used to describe additional tax that is applied to the transaction amount in reference to this specific line item.
        /// </summary>   
        public static string ADDTAXINDLI
        {
            get { return "ADDTAXINDLI"; }
        }

        /// <summary>
        /// Additional tax amount applied to the transaction applicable to this line item record.
        /// </summary>   
        public static string ADDTAXLI
        {
            get { return "ADDTAXLI"; }
        }

        /// <summary>
        /// Rate at which additional tax was assessed.
        /// </summary>   
        public static string ADDTAXRATE
        {
            get { return "ADDTAXRATE"; }
        }

        /// <summary>
        /// Rate at which additional tax was calculated in reference to this specific line item record.
        /// </summary>   
        public static string ADDTAXRATELI
        {
            get { return "ADDTAXRATELI"; }
        }

        /// <summary>
        /// Dollar amount of the transaction. Must be a positive number up to two decimal places.
        /// </summary>   
        public static string AMOUNT
        {
            get { return "AMOUNT"; }
        }

        /// <summary>
        /// Total amount included in the transaction amount generated from this line item record.
        /// </summary>   
        public static string AMOUNTLI
        {
            get { return "AMOUNTLI"; }
        }

        /// <summary>
        /// Approval code for the forced sale is only required and used if TranxType is set to 'Force'.
        /// </summary>   
        public static string APPROVAL
        {
            get { return "APPROVAL"; }
        }

        /// <summary>
        /// Optional URL that the customer will have the option of selecting if their transaction is approved via the PayTrace API Secure Checkout
        /// </summary>   
        public static string APPROVEURL
        {
            get { return "APPROVEURL"; }
        }

        /// <summary>
        /// Number of the batch of transactions you wish to export via an ExportBatch request
        /// </summary>   
        public static string BATCHNUMBER
        {
            get { return "BATCHNUMBER"; }
        }

        /// <summary>
        /// Address that the credit card statement is delivered.
        /// </summary>   
        public static string BADDRESS
        {
            get { return "BADDRESS"; }
        }

        /// <summary>
        /// Second line of the address the credit card statement is delivered.
        /// </summary>   
        public static string BADDRESS2
        {
            get { return "BADDRESS2"; }
        }

        /// <summary>
        /// City that the credit card statement is delivered.
        /// </summary>   
        public static string BCITY
        {
            get { return "BCITY"; }
        }

        /// <summary>
        /// Country code where the billing address is located
        /// </summary>   
        public static string BCOUNTRY
        {
            get { return "BCOUNTRY"; }
        }

        /// <summary>
        /// Name that appears of the credit card.
        /// </summary>   
        public static string BNAME
        {
            get { return "BNAME"; }
        }

        /// <summary>
        /// State that the credit card statement is delivered.
        /// </summary>   
        public static string BSTATE
        {
            get { return "BSTATE"; }
        }

        /// <summary>
        /// Zip code that the credit card statement is delivered.
        /// </summary>   
        public static string BZIP
        {
            get { return "BZIP"; }
        }

        /// <summary>
        /// The attribute causes a  Sale transaction to be processed as a cash advance where cash is given to the customer as opposed to a product or service. 
        /// Please note that Cash Advances may only be processed on accounts that are set up on the TSYS/Vital network and are configured to process Cash Advances. 
        /// Also, only swiped/card present Sales may include the CashAdvance parameter
        /// </summary>   
        public static string CASHADVANCE
        {
            get { return "CASHADVANCE"; }
        }

        /// <summary>
        /// A unique identifier for each transaction in the PayTrace
        ///system. This value is returned in the CHECKIDENTIFIER parameter of an API response and will consequently be included in requests to email receipts, manage checks, etc.
        /// </summary>   
        public static string CHECKID
        {
            get { return "CHECKID"; }
        }

        /// <summary>
        /// The transaction type is the type of transaction you wish to process if the METHOD is set to ProcessCheck. CHECKTYPE must be set to one of the following: Sale, Hold, Refund, Fund, or Void.
        /// </summary>   
        public static string CHECKTYPE
        {
            get { return "CHECKTYPE"; }
        }

        /// <summary>
        /// Commodity code that generally applies to each product included in the order. Commodity codes are generally assigned by your merchant service provider.
        /// </summary>   
        public static string CCODE
        {
            get { return "CCODE"; }
        }

        /// <summary>
        /// The complete commodity code unique to the product referenced in this specific line item record. Commodity codes are generally assigned by your merchant service provider
        /// </summary>   
        public static string CCODELI
        {
            get { return "CCODELI"; }
        }

        /// <summary>
        /// Customer's credit card number must be a valid credit card number that your PayTrace account is set up to accept.
        /// </summary>   
        public static string CC
        {
            get { return "CC"; }
        }

        /// <summary>
        /// CSC is the 3 or 4 digit code found on the signature line of the credit card. CSC is found on the front of Amex cards.
        /// </summary>   
        public static string CSC
        {
            get { return "CSC"; }
        }

        /// <summary>
        /// Optional value that is sent to the cardholder’s issuer and overrides the business name stored in PayTrace. 
        /// Custom DBA values are only used with requests to process sales or authorizations through accounts on the TSYS/Vital, Heartland, and Trident networks.
        /// </summary>   
        public static string CUSTOMDBA
        {
            get { return "CUSTOMDBA"; }
        }

        /// <summary>
        /// Unique identifier for a customer profile. Each customer must have their own unique ID.
        /// </summary>   
        public static string CUSTID
        {
            get { return "CUSTID"; }
        }

        /// <summary>
        /// Password that customer uses to log into customer profile in shopping cart. Only required if you are using the PayTrace shopping cart.
        /// </summary>   
        public static string CUSTPSWD
        {
            get { return "CUSTPSWD"; }
        }

        /// <summary>
        /// Defaulted to N, the customer receipt must be set to Y if a receipt should be emailed to the customer each time the recurring transaction is processed.
        /// </summary>   
        public static string CUSTRECEIPT
        {
            get { return "CUSTRECEIPT"; }
        }

        /// <summary>
        /// Customer reference ID is only used for transactions that are identified as corporate or purchasing credit cards. 
        /// The customer reference ID is an identifier that your customer may ask you to provide in order to reference the transaction to their credit card statement.
        /// </summary>   
        public static string CUSTREF
        {
            get { return "CUSTREF"; }
        }

        /// <summary>
        /// Customer’s tax identifier used for tax reporting purposes
        /// </summary>   
        public static string CUSTOMERTAXID
        {
            get { return "CUSTOMERTAXID"; }
        }

        /// <summary>
        /// Checking account number for processing check transactions or managing customer profiles.
        /// </summary>   
        public static string DDA
        {
            get { return "DDA"; }
        }
        
        /// <summary>
        /// Flag used to determine whether the line item amount was a debit or a credit to the customer. Generally always a debit or a factor that increased the transaction amount.
        /// Possible values are D (net is a debit) and C (net is a credit).
        /// </summary>   
        public static string DCIND
        {
            get { return "DCIND"; }
        }

        /// <summary>
        /// Optional URL that the customer will have the option of selecting if their transaction is declined via the PayTrace API Secure Checkout
        /// </summary>   
        public static string DECLINEURL
        {
            get { return "DECLINEURL"; }
        }

        /// <summary>
        /// Flag used to indicate whether discount was applied to the transaction amount in reference to this specific line item record.
        /// </summary>   
        public static string DISCOUNTIND
        {
            get { return "DISCOUNTIND"; }
        }

        /// <summary>
        /// Discount amount applied to the transaction amount in reference to this line item record.
        /// </summary>   
        public static string DISCOUNTLI
        {
            get { return "DISCOUNTLI"; }
        }

        /// <summary>
        /// Rate at which discount was applied to the transaction in reference to this specific line item.
        /// </summary>   
        public static string DISCOUNTRATE
        {
            get { return "DISCOUNTRATE"; }
        }

        /// <summary>
        /// Duty should represent any costs associated with shipping through a country’s customs.
        /// </summary>   
        public static string DUTY
        {
            get { return "DUTY"; }
        }

        /// <summary>
        /// Optional text describing the transaction, products, customers, or other attributes of the transaction.
        /// </summary>   
        public static string DESCRIPTION
        {
            get { return "DESCRIPTION"; }
        }

        /// <summary>
        /// Discount value should represent the amount discounted from the original transaction amount
        /// </summary>   
        public static string DISCOUNT
        {
            get { return "DISCOUNT"; }
        }

        /// <summary>
        /// Flag that is returned for checks processed through a real-time check processor. 0/zero indicates that the check was accepted.
        /// </summary>   
        public static string ACHCODE
        {
            get { return "ACHCODE"; }
        }

        /// <summary>
        /// Message returned from real-time check processor
        /// </summary>   
        public static string ACHMSG
        {
            get { return "ACHMSG"; }
        }

        /// <summary>
        /// Approval code is generated by credit card issuer and returned when a successful call to ProcessTranx is requested.
        /// </summary>   
        public static string APPCODE
        {
            get { return "APPCODE"; }
        }

        /// <summary>
        /// Approval message is the textual response from the credit card issuer that is returned when a successful call to ProcessTranx is requested.
        /// </summary>   
        public static string APPMSG
        {
            get { return "APPMSG"; }
        }

        /// <summary>
        /// Authorization key is returned with a successful request to validate an order through the PayTrace API Secure Checkout.
        /// </summary>   
        public static string AUTHKEY
        {
            get { return "AUTHKEY"; }
        }

        /// <summary>
        /// The address verification system response is generated by the
        ///credit card issuer when a successful call to ProcessTranx is
        ///requested. AVS compares the billing address and billing zip code
        ///provided with the ProcessTranx request to the address where the
        ///customer's credit card statement is delivered. See Appendix B for
        ///possible AVS responses
        /// </summary>   
        public static string AVSRESPONSE
        {
            get { return "AVSRESPONSE"; }
        }

        /// <summary>
        /// Remaining balance on a prepaid or debit card. This value will only
        ///be returned if ENABLEPARTIALAUTH is set to Y.
        /// </summary>   
        public static string BALANCEAMOUNT
        {
            get { return "BALANCEAMOUNT"; }
        }

        /// <summary>
        /// Batch number is returned with a successful request to settle
        ///transactions. This value is the sequential number assigned to the
        ///batch that was initiated.
        /// </summary>   
        public static string BATCHNUM
        {
            get { return "BATCHNUM"; }
        }

        /// <summary>
        /// ID assigned by PayTrace to each check at the time the check is
        ///processed. CHECKIDENTIFIER is returned with a successful call to
        ///ProcessCheck.
        /// </summary>   
        public static string CHECKIDENTIFIER
        {
            get { return "CHECKIDENTIFIER"; }
        }

        /// <summary>
        /// The card security code response is generated by the credit card
        ///issuer when a successful call to the ProcessTranx is requested. The
        ///CSC provided with the ProcessTranx request. is compared to the
        ///CSC assigned to the credit card. See Appendix B for possible AVS
        ///responses
        /// </summary>   
        public static string CSCRESPONSE
        {
            get { return "CSCRESPONSE"; }
        }

        /// <summary>
        /// ID assigned by PayTrace to each customer at the time the
        ///customer profile is created. CustomerID is returned with a
        ///successful call to CreateCustomer or UpdateCustomer.
        /// </summary>   
        public static string CUSTOMERID
        {
            get { return "CUSTOMERID"; }
        }

        /// <summary>
        /// Formatted customer record returned when a successful call to
        ///ExportCustomers method is requested.
        /// </summary>   
        public static string CUSTOMERRECORD
        {
            get { return "CUSTOMERRECORD"; }
        }

        /// <summary>
        /// End date is used for export functions to indicate when to end searching for items to export. Must be a valid date formatted as MM/DD/YYYY
        /// </summary>   
        public static string EDATE
        {
            get { return "EDATE"; }
        }

        /// <summary>
        /// Customer's email address where the sales receipt may be sent.
        /// </summary>   
        public static string EMAIL
        {
            get { return "EMAIL"; }
        }

        /// <summary>
        /// Flag that must be set to ‘Y’ in order to support partial authorization and balance amounts in transaction responses.
        /// </summary>   
        public static string ENABLEPARTIALAUTH
        {
            get { return "ENABLEPARTIALAUTH"; }
        }

        /// <summary>
        /// PayTrace validates each name / value pair it receives. If any errors
        ///or inconsistencies in this data or the request, PayTrace will return
        ///an error. Each request may return multiple errors.
        /// </summary>   
        public static string ERROR
        {
            get { return "ERROR"; }
        }

        /// <summary>
        /// Expiration month must be the two-digit month of the credit cards expiration date.
        /// </summary>   
        public static string EXPMNTH
        {
            get { return "EXPMNTH"; }
        }

        /// <summary>
        /// Expiration year must be the two digit year of the credit cards expiration date.
        /// </summary>   
        public static string EXPYR
        {
            get { return "EXPYR"; }
        }

        /// <summary>
        /// Customer's fax number (i.e. (555)555-5555, 555-555-5555, or 5555555555).
        /// </summary>   
        public static string FAX
        {
            get { return "FAX"; }
        }

        /// <summary>
        /// Setting in the PayTrace API Secure Checkout that may be set to ‘Y’ if the customer’s complete billing address is required.
        /// </summary>   
        public static string FORCEADDRESS
        {
            get { return "FORCEADDRESS"; }
        }

        /// <summary>
        /// Setting in the PayTrace API Secure Checkout that may be set to ‘Y’ if the customer’s CSC is required.
        /// </summary>   
        public static string FORCECSC
        {
            get { return "FORCECSC"; }
        }

        /// <summary>
        /// Setting in the PayTrace API Secure Checkout that may be set to ‘Y’ if the customer’s email address is required.
        /// </summary>   
        public static string FORCEEMAIL
        {
            get { return "FORCEEMAIL"; }
        }

        /// <summary>
        /// Freight value should represent the portion of the transaction amount that was generated from shipping costs.
        /// </summary>   
        public static string FREIGHT
        {
            get { return "FREIGHT"; }
        }

        /// <summary>
        /// The billing cycle of the recurring transaction must be 1 for annually, 8 for semi-annually, A for trimesterly, 2 for quarterly, 9 for bi-monthly, , 3 for monthly, 4 for biweekly, 7 
        /// for 1st and 15th, 5 for weekly, or 6 for daily.
        /// </summary>   
        public static string FREQUENCY
        {
            get { return "FREQUENCY"; }
        }

        /// <summary>
        /// Only used when processing Cash Advances. This required field is the expiration date of the card holder’s photo ID. MM/DD/YYYY
        /// </summary>   
        public static string IDEXP
        {
            get { return "IDEXP"; }
        }

        /// <summary>
        /// Invoice is the identifier for this transaction in your accounting or inventory management system.
        /// </summary>   
        public static string INVOICE
        {
            get { return "INVOICE"; }
        }

        /// <summary>
        /// IP address of the computer that originally requested the customer
        ///profile or transaction be created or processed formatted as a
        ///standard IP address (I.e. 111.111.111.111). IP address is returned
        ///with a successful call to ExportCustomers or ExportTranx.
        /// </summary>   
        public static string IP
        {
            get { return "IP"; }
        }

        /// <summary>
        /// Only used when processing Cash Advances. This required field is the last 4 digits of the card number as it appears on the face of the card.
        /// </summary>   
        public static string LAST4
        {
            get { return "LAST4"; }
        }

        /// <summary>
        /// Unit of measure applied to the product and its quantity. For example, LBS/LITERS, OUNCES, etc.
        /// </summary>   
        public static string MEASURE
        {
            get { return "MEASURE"; }
        }

        /// <summary>
        /// Merchant’s tax identifier used for tax reporting purposes.
        /// </summary>   
        public static string MERCHANTTAXID
        {
            get { return "MERCHANTTAXID"; }
        }

        /// <summary>
        /// Function that you are requesting PayTrace perform. All methods are discussed in section 4.
        /// </summary>   
        public static string METHOD
        {
            get { return "METHOD"; }
        }

        /// <summary>
        /// Net amount is returned with a successful request to settle
        ///transactions. This value is the net amount (sales minus refunds) of
        ///the batch that was initiated.
        /// </summary>   
        public static string NETAMOUNT
        {
            get { return "NETAMOUNT"; }
        }

        /// <summary>
        /// Flag used to indicate whether the line item amount is net or gross to specify whether the line item amount includes tax. 
        /// Possible values are Y (includes tax) and N (does not include tax).
        /// </summary>   
        public static string NETGROSSIND
        {
            get { return "NETGROSSIND"; }
        }

        /// <summary>
        /// Unique identifier for a customer profile that may be sent with request to update a customer profile. This value will be the new customer ID.
        /// </summary>   
        public static string NEWCUSTID
        {
            get { return "NEWCUSTID"; }
        }

        /// <summary>
        /// Your new PayTrace password when updating user password through the UpdatePassword method.
        /// </summary>   
        public static string NEWPSWD
        {
            get { return "NEWPSWD"; }
        }

        /// <summary>
        /// Confirmation of you new PayTrace password when updating user password through the UpdatePassword method.
        /// </summary>   
        public static string NEWPSWD2
        {
            get { return "NEWPSWD2"; }
        }

        /// <summary>
        /// Next date the updated recurring transaction should be processed.
        /// </summary>   
        public static string NEXT
        {
            get { return "NEXT"; }
        }

        /// <summary>
        /// Portion of the original transaction amount that is national tax. Generally only applicable to orders shipped to countries with a national or value added tax.
        /// </summary>   
        public static string NTAX
        {
            get { return "NTAX"; }
        }

        /// <summary>
        /// Developer’s identifier for an order that is placed through the PayTrace API Secure Checkout
        /// </summary>   
        public static string ORDERID
        {
            get { return "ORDERID"; }
        }

        /// <summary>
        /// Unique identifier of the request from your system that will be returned in the response if RETURNID is set to Y
        /// </summary>   
        public static string ORIGINALID
        {
            get { return "ORIGINALID"; }
        }

        /// <summary>
        /// Number of records from result set that should be returned in the Export--- request. This can be used to return only a section of the complete result set.
        /// </summary>   
        public static string PAGESIZE
        {
            get { return "PAGESIZE"; }
        }

        /// <summary>
        /// First record from the result set that should be returned in the Export--- request. This can be used to return only a section of the complete result set.
        /// </summary>   
        public static string PAGESTART
        {
            get { return "PAGESTART"; }
        }

        /// <summary>
        /// Authorized transaction amount in the event that a transaction is
        ///partially approved. This value will only be returned if
        ///ENABLEPARTIALAUTH is set to Y.
        /// </summary>   
        public static string PARTIALAMOUNT
        {
            get { return "PARTIALAMOUNT"; }
        }

        /// <summary>
        /// Customer's phone number (i.e. (555)555-5555, 555-555-5555, or 5555555555).
        /// </summary>   
        public static string PHONE
        {
            get { return "PHONE"; }
        }

        /// <summary>
        /// Only used when processing Cash Advances. This required field may be the card holder’s drivers license number or other form of photo ID.
        /// </summary>   
        public static string PHOTOID
        {
            get { return "PHOTOID"; }
        }

        /// <summary>
        /// Optional URL with any request where the response/error generated from the request may be sent in addition to the comptuer that originated the request.
        /// </summary>   
        public static string POSTURL
        {
            get { return "POSTURL"; }
        }

        /// <summary>
        /// Your unique identifier for the product.
        /// </summary>   
        public static string PRODUCTID
        {
            get { return "PRODUCTID"; }
        }

        /// <summary>
        /// Your PayTrace password is required to authenticate your request.*
        /// </summary>   
        public static string PSWD
        {
            get { return "PSWD"; }
        }

        /// <summary>
        /// Item count of the product in this order
        /// </summary>   
        public static string QUANTITY
        {
            get { return "QUANTITY"; }
        }

        /// <summary>
        /// The ID of the Recurring Transaction that is being updated.
        /// </summary>   
        public static string RECURID
        {
            get { return "RECURID"; }
        }

        /// <summary>
        /// Default value is C which represents credit card number. Alternative is A which represents an ACH/check transaction.
        /// </summary>   
        public static string RECURTYPE
        {
            get { return "RECURTYPE"; }
        }

        /// <summary>
        /// Total amount of refunds included in a batch. This value is returned
        /// in ExportBatches requests.
        /// </summary>   
        public static string REFUNDAMOUNT
        {
            get { return "REFUNDAMOUNT"; }
        }

        /// <summary>
        /// Total number of refunds included in a batch. This value is returned
        /// in ExportBatches requests.
        /// </summary>   
        public static string REFUNDCOUNT
        {
            get { return "REFUNDCOUNT"; }
        }

        /// <summary>
        /// Sentence or two that confirms the method that was requested.
        /// </summary>   
        public static string RESPONSE
        {
            get { return "RESPONSE"; }
        }

        /// <summary>
        /// If set to Y, card numbers from ExportTranx and ExportCustomers requests will include the first 6 and last 4 digits of the card number
        /// </summary>   
        public static string RETURNBIN
        {
            get { return "RETURNBIN"; }
        }

        /// <summary>
        /// If set to Y, card level results will be returned w/ theresponse. Card level results include whether or not the card is a consumer, purchasing, check, rewards, etc. 
        /// account. Card level results are only returned with requests to process sales or authorizations through accounts on the TSYS/Vital, Heartland, and Trident networks.
        /// </summary>   
        public static string RETURNCLR
        {
            get { return "RETURNCLR"; }
        }

        /// <summary>
        /// If set to Y will return the value of ORIGINALID in the response.
        /// </summary>   
        public static string RETURNID
        {
            get { return "RETURNID"; }
        }

        /// <summary>
        /// Address where the product is delivered.
        /// </summary>   
        public static string SADDRESS
        {
            get { return "SADDRESS"; }
        }

        /// <summary>
        /// Second line of the address where the product is delivered.
        /// </summary>   
        public static string SADDRESS2
        {
            get { return "SADDRESS2"; }
        }

        /// <summary>
        /// Total amount of sales included in a batch. This value is returned in
        /// ExportBatches requests.
        /// </summary>   
        public static string SALESAMOUNT
        {
            get { return "SALESAMOUNT"; }
        }

        /// <summary>
        /// Total number of sales included in a batch. This value is returned in
        /// ExportBatches requests.
        /// </summary>   
        public static string SALESCOUNT
        {
            get { return "SALESCOUNT"; }
        }

        /// <summary>
        /// City where the product is delivered.
        /// </summary>   
        public static string SCITY
        {
            get { return "SCITY"; }
        }

        /// <summary>
        /// Country that the package will be delivered to.
        /// </summary>   
        public static string SCOUNTRY
        {
            get { return "SCOUNTRY"; }
        }

        /// <summary>
        /// County where the product is delivered.
        /// </summary>   
        public static string SCOUNTY
        {
            get { return "SCOUNTY"; }
        }

        /// <summary>
        /// Start date is used for export functions to indicate when to start searching for items to export. Must be a valid date formatted as MM/DD/YYYY.
        /// </summary>   
        public static string SDATE
        {
            get { return "SDATE"; }
        }

        /// <summary>
        /// Text that will be searched to narrow down transaction and check results for ExportTranx and ExportCheck requests.
        /// </summary>   
        public static string SEARCHTEXT
        {
            get { return "SEARCHTEXT"; }
        }

        /// <summary>
        /// Date and Time returned with the TransactionRECORD formatted a
        /// general date (i.e. MM/DD/YYYY HH:MM:SS). Settled represents
        /// the date and time the transaction was settled/batched.
        /// </summary>   
        public static string SETTLED
        {
            get { return "SETTLED"; }
        }

        /// <summary>
        /// String of shipping service providers you would like shipping quotes from. String may contain USPS, FEDEX, or UPS in any order or combination.
        /// </summary>   
        public static string SHIPPERS
        {
            get { return "SHIPPERS"; }
        }

        /// <summary>
        /// The name of the shipping company that quoted the price (i.e. UPS, USPS, FEDEX).
        /// </summary>   
        public static string SHIPPINGCOMPANY
        {
            get { return "SHIPPINGCOMPANY"; }
        }

        /// <summary>
        /// The method of shipment that was quoted (i.e. Next Day, Priority, Ground, etc.).
        /// </summary>   
        public static string SHIPPINGMETHOD
        {
            get { return "SHIPPINGMETHOD"; }
        }

        /// <summary>
        /// Cost to use the specified shipping service provider and method
        /// formatted in U.S. dollars as provided by the shipping service
        /// provider.
        /// </summary>   
        public static string SHIPPINGRATE
        {
            get { return "SHIPPINGRATE"; }
        }

        /// <summary>
        /// Shipping records are returned when a successful call to
        /// CalculateShipping is requested.
        /// </summary>   
        public static string SHIPPINGRECORD
        {
            get { return "SHIPPINGRECORD"; }
        }

        /// <summary>
        /// Name of the person where the product is delivered.
        /// </summary>   
        public static string SNAME
        {
            get { return "SNAME"; }
        }

        /// <summary>
        /// State that the package will be sent from.
        /// </summary>   
        public static string SOURCESTATE
        {
            get { return "SOURCESTATE"; }
        }

        /// <summary>
        /// Zip code that the package will be sent from.
        /// </summary>   
        public static string SOURCEZIP
        {
            get { return "SOURCEZIP"; }
        }

        /// <summary>
        /// State where the product is delivered.
        /// </summary>   
        public static string SSTATE
        {
            get { return "SSTATE"; }
        }

        /// <summary>
        /// Date the recurring transaction should be processed for the first time.
        /// </summary>   
        public static string START
        {
            get { return "START"; }
        }

        /// <summary>
        /// Status is returned with each transaction in the transaction list that
        /// is returned from a successful call to the ExportTranx method. If
        /// the status contains the letters "GB" then the transaction has been
        /// settled, and the batch number will be appended to the status. If
        /// the is "Y" then the transaction will be settled that evening. If the
        /// status is "N" then the transaction was voided or declined.
        /// </summary>   
        public static string STATUS
        {
            get { return "STATUS"; }
        }

        /// <summary>
        /// Optional future date when the transaction should beauthorized and settled. Only applicable if the TranxType is STR/FWD
        /// </summary>   
        public static string STRFWDDATE
        {
            get { return "STRFWDDATE"; }
        }

        /// <summary>
        /// The value of the magnetic stripe on the back of the credit
        /// card as recorded from a magnetic card reader. PayTrace
        /// strongly recommends that software providers avoid storing
        /// the swiped value. Because the first value in the magnetic
        /// stripe is a (%) symbol, we strongly recommend URL
        /// encoding the SWIPE value before posting it to PayTrace.
        /// Please note that PayTrace supports encrypted card
        /// readers. However, most encrypted card readers include
        /// pipe (|) symbols in the magstripe value. It is imperative
        /// that you replace these pipe symbols with “***” to ensure
        /// that the API is able to parse your request.
        /// </summary>   
        public static string SWIPE
        {
            get { return "SWIPE"; }
        }

        /// <summary>
        /// Zip code where the product is delivered.
        /// </summary>   
        public static string SZIP
        {
            get { return "SZIP"; }
        }

        /// <summary>
        /// Portion of the original transaction amount that is tax. Must
        /// be a number that reports the tax amount of the
        /// transaction. Use -1 if the transaction is tax exempt
        /// </summary>   
        public static string TAX
        {
            get { return "TAX"; }
        }

        /// <summary>
        /// Must be to 'Y' in order to process any methods through the
        /// PayTrace API. Setting this variable to 'Y' indicates that you agree to
        /// the PayTrace terms and conditions found at
        /// https://paytrace.com/terms.html
        /// </summary>   
        public static string TERMS
        {
            get { return "TERMS"; }
        }

        /// <summary>
        /// The TEST attribute may be used with any of the
        ///transaction types (TranxType) of the ProcessTranx
        ///method. The value of the TEST attribute may only be a
        ///“Y”. Transactions processed with a TEST value of “Y” will
        ///be processed as test transactions with standardized test
        ///responses. Test transactions will not place a hold on the
        ///customer’s credit card.
        /// </summary>   
        public static string TEST
        {
            get { return "TEST"; }
        }

        /// <summary>
        /// The total number of times the recurring transaction should
        /// be processed. Use 999 if the recurring transaction should
        /// be processed indefinitely.
        /// </summary>   
        public static string TOTALCOUNT
        {
            get { return "TOTALCOUNT"; }
        }

        /// <summary>
        /// Transit routing number for processing check transactions
        /// or managing customer profiles.
        /// </summary>   
        public static string TR
        {
            get { return "TR"; }
        }

        /// <summary>
        /// ID assigned by PayTrace to each transaction at the time the
        /// transaction is processed. TransactionID is returned with a
        /// successful call to ProcessTranx.
        /// </summary>   
        public static string TRANSACTIONID
        {
            get { return "TRANSACTIONID"; }
        }

        /// <summary>
        /// Formatted transaction record returned when a successful call to
        /// ExportTranx method is requested.
        /// </summary>   
        public static string TRANSACTIONRECORD
        {
            get { return "TRANSACTIONRECORD"; }
        }

        /// <summary>
        /// Transaction count is returned with a successful request to settle
        /// transactions. This value is the total number of transactions that
        /// were included in the batch.
        /// </summary>   
        public static string TRANXCOUNT
        {
            get { return "TRANXCOUNT"; }
        }

        /// <summary>
        /// A unique identifier for each transaction in the PayTrace
        /// system. This value is returned in the TRANSACTIONID
        /// parameter of an API response and will consequently be
        /// included in requests to email receipts, void transactions,
        /// add level 3 data, etc.
        /// </summary>   
        public static string TRANXID
        {
            get { return "TRANXID"; }
        }

        /// <summary>
        /// The transaction type is the type of transaction you wish to
        /// process if the METHOD is set to ProcessTranx. TRANXTYPE
        /// must be set to one of the following: Sale, Authorization,
        /// Str/Fwd, Refund, Void, Capture, Force or Deleteauthkey.
        /// </summary>   
        public static string TRANXTYPE
        {
            get { return "TRANXTYPE"; }
        }

        /// <summary>
        /// Your PayTrace user name is required to authenticate your request.
        /// </summary>   
        public static string UN
        {
            get { return "UN"; }
        }

        /// <summary>
        /// Product amount per quantity.
        /// </summary>   
        public static string UNITCOST
        {
            get { return "UNITCOST"; }
        }

        /// <summary>
        /// User is the user name of the PayTrace user who created or
        /// processed the customer or transaction you are trying to
        /// export. This variable is a search criterion for the export
        /// methods.
        /// </summary>   
        public static string USER
        {
            get { return "USER"; }
        }

        /// <summary>
        /// Total sum of Visa refunds that were settled in the exported batch.
        /// Similar values will be returned for all applicable card types, i.e.
        /// Total sum of Visa refunds that were settled in the exported batch.
        /// Similar values will be returned for all applicable card types, i.e.
        /// MasterCardRefundAmount, AmexRefundAmount,
        /// DiscoverRefundCount, etc.
        /// </summary>   
        public static string VISAREFUNDAMOUNT
        {
            get { return "VISAREFUNDAMOUNT"; }
        }

        /// <summary>
        /// Total number of Visa refunds that were settled in the exported
        /// batch. Similar values will be returned for all applicable card types,
        /// i.e. MasterCardRefundCount, AmexRefundCount,
        /// DiscoverRefundCount, etc.
        /// </summary>   
        public static string VISAREFUNDCOUNT
        {
            get { return "VISAREFUNDCOUNT"; }
        }

        /// <summary>
        /// Total sum of Visa sales that were settled in the exported batch.
        /// Similar values will be returned for all applicable card types, i.e.
        /// MasterCardSalesAmount, AmexSalesAmount, DiscoverSalesCount,
        /// etc.
        /// </summary>   
        public static string VISASALESAMOUNT
        {
            get { return "VISASALESAMOUNT"; }
        }

        /// <summary>
        /// Total number of Visa sales that were settled in the exported batch.
        /// Similar values will be returned for all applicable card types, i.e.
        /// MasterCardSalesCount, AmexSalesCount, DiscoverSalesCount, etc.
        /// </summary>   
        public static string VISASALESCOUNT
        {
            get { return "VISASALESCOUNT"; }
        }

        /// <summary>
        /// Weight of the package that is being shipped. Weight must
        /// be provided in pounds and my have up to two decimals.
        /// Weight must be less than 70 pounds
        /// </summary>   
        public static string WEIGHT
        {
            get { return "WEIGHT"; }
        }

        /// <summary>
        /// Date and Time returned with the TransactionRECORD and the
        /// CustomerRECORD formatted a general date (i.e. MM/DD/YYYY
        /// HH:MM:SS). When represents the date and time the transaction
        /// was first processed or the customer profile was created.
        /// </summary>   
        public static string WHEN
        {
            get { return "WHEN"; }
        }
        /// <summary>
        /// URL for Secure Checkout silent post. 
        /// </summary>
        public static string RETURNURL {
            get { return "RETURNURL"; } 
        }
    }

}
