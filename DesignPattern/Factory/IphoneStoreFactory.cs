using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal class IphoneStoreFactory:AppleStoreFactory
    {
        internal override ApplePrice CreateApplePriceFactory(string type)
        {
            ApplePrice ap = null;
            switch (type)
            {
                case "Iphone5":
                    ap = new Iphone5Price();
                    break;
                case "Iphone6":
                    ap = new Iphone6Price();
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
