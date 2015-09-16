using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    internal class IpadProductSize:ProductSize
    {
        internal override void Size()
        {
            Console.WriteLine("Ipad尺寸：9.7寸");
        }
    }
}
