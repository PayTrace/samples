using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayTrace.Integration;

namespace PayTrace.Integration.Test
{
    [TestClass]
    public class ContextTestHarness
    {
        [TestMethod]
        public void GetContextObject()
        {
            var current = new Context();
            
        }
    }
}
