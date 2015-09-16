using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    internal class Iphone5Price : IphonePrice
    {
        internal override void Price()
        {
            Console.WriteLine("Iphone5售价:3288￥");
        }
    }
}
