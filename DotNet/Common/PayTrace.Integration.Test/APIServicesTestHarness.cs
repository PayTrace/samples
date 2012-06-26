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

            Dictionary<string, string> name_value_pairs = APIParser.ParseAPIMessage(raw_response);
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
        public void API_Builder_should_return_api_formatted_string()
        {
            Dictionary<string, string> api = new Dictionary<string, string>();
            api.Add("Test1", "Value 1");
            api.Add("Test2", "Value 2");

            string api_call = APIBuilder.BuildAPICall(api);

            Assert.AreEqual("Test1~Value 1|Test2~Value 2|", api_call);
    
        }



    }
}
