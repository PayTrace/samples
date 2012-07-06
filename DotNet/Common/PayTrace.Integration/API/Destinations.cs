using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayTrace.Integration.API
{
    public class Destinations 
    {
        /// <summary>
        /// Validation portion of secure checkout
        /// </summary>
        public static Uri Validation { get { return new Uri( DestinationList.Validation); } }

        /// <summary>
        /// Payment portion of secure checkout
        /// </summary>
        public static Uri Checkout { get { return new Uri(DestinationList.Checkout); } }

        /// <summary>
        /// Traditional API
        /// </summary>
        public static Uri Default { get { return new Uri(DestinationList.Default); } }

        /// <summary>
        /// Authorize.net emulator
        /// </summary>
        public static Uri Gateway { get { return new Uri(DestinationList.Gateway); } }
    }

    
}
