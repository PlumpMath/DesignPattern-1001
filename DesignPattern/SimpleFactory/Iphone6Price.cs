using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    internal class Iphone6Price : IphonePrice
    {
        internal override void Price()
        {
            Console.WriteLine("Iphone6售价：5288");
        }
    }
}
