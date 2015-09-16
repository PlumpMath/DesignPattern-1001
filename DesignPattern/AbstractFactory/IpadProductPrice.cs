using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class IpadProductPrice:ProductPrice
    {
        internal override void Price()
        {
            Console.WriteLine("Ipad价格：4288￥");
        }
    }
}
