using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class IphoneProductSize:ProductSize
    {
        internal override void Size()
        {
            Console.WriteLine("Iphone尺寸：4.7寸");
        }
    }
}
