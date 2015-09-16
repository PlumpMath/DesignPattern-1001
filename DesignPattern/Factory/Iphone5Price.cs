using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal class Iphone5Price : ApplePrice
    {
        internal override void Price()
        {
            Console.WriteLine("Iphone5售价:3288￥");
        }
    }
}
