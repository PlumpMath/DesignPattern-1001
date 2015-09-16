using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class Woman:Person
    {
        internal override void Wear()
        {
            Console.WriteLine("女人");
        }
    }
}
