using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal abstract class AppleFactory
    {
        internal abstract ProductSize CreateProductSize();
        internal abstract ProductPrice CreateProductPrice();
    }
}
