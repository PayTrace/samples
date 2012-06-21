using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayTrace.Integration;

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
        public void Response_object_should_be_able_to_parse_response_into_name_value_pairs()
        {
            string expected = "1";

            string raw_response = "TestValue1~1|TestValue2~2";
            Response ServiceResponce = new Response(raw_response);

            Assert.AreEqual(ServiceResponce.ResponseValues["TestValue1"], expected);
        }
    }
}
