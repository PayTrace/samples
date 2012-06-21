using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StructureMap;
using StructureMap.Configuration.DSL;
namespace PayTrace.Integration
{
    public class Context 
    {
        private Container container = null;

        public Context(Registry registry)
        {
            container = new Container(registry);
        }

        public Context()
        {
            container = new Container(new APIRegistry());
        }


        
    }

}

