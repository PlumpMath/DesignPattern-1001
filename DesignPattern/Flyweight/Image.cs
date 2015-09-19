using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    internal class Image:FlyweightImage
    {
        internal override void Show(string count)
        {
            Console.WriteLine("我是{0}张图片",count);
        }
    }
}
