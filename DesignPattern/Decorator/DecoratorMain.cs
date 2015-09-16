using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class DecoratorMain
    {
        public void Execute()
        {
            Person p = new Woman();
            Necklace n = new Necklace(p);
            Ring r = new Ring(n);
            r.Wear();
        }
    }
}
