using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class IphoneProductPrice:ProductPrice
    {
        internal override void Price()
        {
            Console.WriteLine("Iphone价格：5288￥");
        }
    }
}
