using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal abstract class AppleStoreFactory
    {
        internal abstract ApplePrice CreateApplePriceFactory(string type);
    }
}
