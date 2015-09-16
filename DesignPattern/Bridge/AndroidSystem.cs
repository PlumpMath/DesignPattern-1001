using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    internal  class AndroidSystem:System
    {
        internal override void Run()
        {
            Console.WriteLine("运行Android系统的：");
            apps.Show();
        }
    }
}
