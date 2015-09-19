using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    internal abstract class LucencyComponet
    {
        protected string name;

        internal string Name
        {
            get { return name; }
            set { name = value; }
        }
        internal LucencyComponet(string name) 
        {
            this.name = name;
        }
        internal abstract void Display(int depth);
        internal abstract void Add(LucencyComponet lc);
        internal abstract void Remove(LucencyComponet lc);
    }
}
