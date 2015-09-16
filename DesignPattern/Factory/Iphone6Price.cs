using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal class Iphone6Price:ApplePrice
    {
        internal override void Price()
        {
            Console.WriteLine("Iphone6售价：5288");
        }
    }
}
