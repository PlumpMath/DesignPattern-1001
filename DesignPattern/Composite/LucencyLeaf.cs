using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    internal class LucencyLeaf : LucencyComponet
    {
        public LucencyLeaf(string name):base(name) 
        {
        }
        internal override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
        internal override void Add(LucencyComponet lc)
        {
            throw new NotImplementedException();
        }

        internal override void Remove(LucencyComponet lc)
        {
            throw new NotImplementedException();
        }
    }
}
