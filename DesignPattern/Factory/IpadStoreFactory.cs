using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal class IpadStoreFactory : AppleStoreFactory
    {
        internal override ApplePrice CreateApplePriceFactory(string type)
        {
            ApplePrice ap = null;
            switch (type)
            {
                case "IpadMini":
                    ap = new IpadMiniPrice();
                    break;
                case "IpadAir":
                    ap = new IpadAirPrice();
                    break;
                default:
                    break;
            }
            if (ap == null)
                throw new Exception();
            return ap;
        }
    }
}
