using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayTrace.Integration;
using PayTrace.Integration.API;


namespace PayTrace.Integration.Test
{
    [TestClass]
    public class APIServicesTestHarness
    {
        [TestMethod]
        public void API_parser_should_be_able_to_parse_name_value_pairs()
        {
            string raw_response = "TestValue1~1|TestValue2~2";
            string expected = "1";

            Dictionary<string, string> name_value_pairs = Parser.ParseAPIMessage(raw_response);
            Assert.AreEqual(name_value_pairs["TestValue1"], expected);
        }

        [TestMethod]
        public void API_parser_should_be_able_to_parse_with_blank_pipe_at_the_end()
        {
            string raw_response = "TestValue1~1|TestValue2~2|";
            string expected = "1";

            Dictionary<string, string> name_value_pairs = Parser.ParseAPIMessage(raw_response);
            Assert.AreEqual(name_value_pairs["TestValue1"], expected);
        }

        [TestMethod]
        public void Should_Parse_Error_an_error_message()
        {
            string raw_response_error = "ERROR~48. Please provide an Amount that is less than your Sale Ceiling Amount.|";
            var ServiceResponse = new Response(raw_response_error);

            Assert.IsTrue(ServiceResponse.HasError);
        }

        [TestMethod]
        public void Should_include_error_object_when_error_exists()
        {
            string raw_response_error = "ERROR~48. Please provide an Amount that is less than your Sale Ceiling Amount.|";

            var ServiceResponse = new Response(raw_response_error);

            Assert.IsTrue(ServiceResponse.HasError);
            var Error = ServiceResponse.Error;
            Assert.IsNotNull(Error);
            Assert.AreEqual(Error.ID, 48);
            Assert.AreEqual(Error.Message, "Please provide an Amount that is less than your Sale Ceiling Amount.");

        }

        [TestMethod]
        public void Response_object_should_be_able_to_parse_response_into_name_value_pairs()
        {
            string expected = "1";
            string also_expected ="2";
            string raw_response = "TestValue1~1|TestValue2~2";
            Response ServiceResponse = new Response(raw_response);

            Assert.AreEqual(ServiceResponse.ResponseValues["TestValue1"], expected);
            Assert.AreEqual(ServiceResponse.ResponseValues["TestValue2"], also_expected);
        }

        [TestMethod]
        public void Formatter_should_return_api_formatted_string()
        {
            Dictionary<string, string> api = new Dictionary<string, string>();
            api.Add("Test1", "Value 1");
            api.Add("Test2", "Value 2");

            string api_call = Formatter.BuildAPICall(api);

            Assert.AreEqual("Test1~Value 1|Test2~Value 2|", api_call);
    
        }

        [TestMethod]
        public void Request_should_not_add_key_values_where_value_is_null()
        {
            Request request = new Request();

            request[Keys.ORDERID] =  "1234";
            request[Keys.ORDERID] = null;

            var actual = request.ToAPI();

            Assert.IsFalse(actual.ContainsKey(Keys.ORDERID));
        }

        [TestMethod]
        public void Request_should_return_a_dictionary()
        {
            Request request = new Request();

            request.Add(Keys.ORDERID, "1234");

            var actual = request.ToAPI();

            Assert.AreEqual(actual[Keys.ORDERID], "1234");

        }

        [TestMethod]
        public void Request_should_return_Y_if_true_for_boolean_poperties()
        {
            Request DBuilder = new Request();
      
            DBuilder.Add(Keys.FORCECSC, true);

            var actual = DBuilder.ToAPI();

            Assert.AreEqual(actual[Keys.FORCECSC], "Y");
            
        }

        [TestMethod]
        public void Request_should_not_contain_a_value_if_boolean_false()
        {
            Request DBuilder = new Request();

            DBuilder.Add(Keys.FORCEADDRESS, false);

            var actual = DBuilder.ToAPI();

            Assert.IsFalse(actual.Any(x => x.Key == Keys.FORCEADDRESS));
        }

        [TestMethod]
        public void Adding_shipping_to_a_request_should_add_shipping_info_to_library()
        {
            AddressInfo address = new AddressInfo(street: "1234 happy lane",city:"Seattle");

            Request request = new Request();

            request.AddShippingAddress(address);

            var dictionary =  request.GetAPIDictionary();

            Assert.AreEqual(dictionary["SADDRESS"], "1234 happy lane");
            Assert.AreEqual(dictionary[Keys.SCITY],"Seattle");
        }

       


    }
}
