using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    internal class RealBuyPerson : Person
    {

        internal override void Buy()
        {
            Console.WriteLine("帮我买一个Iphone6s");
        }
    }
}
