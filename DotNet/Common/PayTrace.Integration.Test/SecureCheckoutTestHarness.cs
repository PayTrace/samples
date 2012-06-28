using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayTrace.Integration;
using PayTrace.Integration.SecureCheckout;


namespace PayTrace.Integration.Test
{
    /// <summary>
    /// Summary description for SecureCheckoutTestHarness
    /// </summary>
    [TestClass]
    public class SecureCheckoutTestHarness
    {
        public SecureCheckoutTestHarness()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        [IgnoreAttribute]
        public void OrderValidation_Should_Return_be_able_to_generate_API_Format()
        {
            OrderValidation order = new OrderValidation();

            order.ApprovalURL = "www.example.com/approval.html";
            order.DeclineURL = "www.example.com/decline.html";
            order.ReturnURL = "www.example.com/return.html";
            order.ForceAddress = false;
            order.ForceEmail = true;
            order.OrderID = "1234";

            var validation_items =  order.to_PayTraceAPI();
            
        }

        [TestMethod]
        public void Validate_new_order()
        {

            //SecureCheckout Checkout = new SecureCheckout( new Authentication());
            //Authorization responce = Checkout.GetAuthorization();

            //Assert.IsNotNull(responce);
        }
    }
}
