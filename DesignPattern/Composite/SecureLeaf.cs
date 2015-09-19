using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    internal class SecureLeaf : SecureComponet
    {
        internal SecureLeaf(string name)
            : base(name)
        {
        }
        internal override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

    }
}
