using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class IpadFactory:AppleFactory
    {
        internal override ProductSize CreateProductSize()
        {
            return new IpadProductSize();
        }

        internal override ProductPrice CreateProductPrice()
        {
            return new IpadProductPrice();
        }
    }
}
