using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    internal class FriendProxy:Person
    {
        RealBuyPerson rbPerson;
        internal override void Buy()
        {
            if (rbPerson==null)
            {
                rbPerson = new RealBuyPerson();
            }
            rbPerson.Buy();
            Console.WriteLine("帮你买了一部Iphone6s");
        }

    }
}
