using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class LucencyComposite : LucencyComponet
    {
        private List<LucencyComponet> list = new List<LucencyComponet>();
        public LucencyComposite(string name):base (name) 
        {

        }
        internal override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var item in list)
            {
                item.Display(depth+2);
            }
        }

        internal override void Add(LucencyComponet lc)
        {
            list.Add(lc);
        }

        internal override void Remove(LucencyComponet lc)
        {
            list.Remove(lc);
        }
    }
}
