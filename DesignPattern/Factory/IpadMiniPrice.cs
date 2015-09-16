using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal class IpadMiniPrice : ApplePrice
    {
        internal override void Price()
        {
            Console.WriteLine("IpadMini售价：3088");
        }
    }
}
