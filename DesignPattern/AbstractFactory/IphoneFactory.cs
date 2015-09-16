using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class IphoneFactory : AppleFactory
    {
        internal override ProductSize CreateProductSize()
        {
            return new IphoneProductSize();
        }

        internal override ProductPrice CreateProductPrice()
        {
            return new IphoneProductPrice();
        }
    }
}
