using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    internal class IosSystem:System
    {
        internal override void Run()
        {
            Console.WriteLine("运行Ios系统的：");
            apps.Show();
        }
    }
}
