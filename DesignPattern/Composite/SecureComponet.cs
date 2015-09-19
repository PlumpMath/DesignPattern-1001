using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    internal abstract class SecureComponet
    {
        protected string name { get; set; }
        internal SecureComponet(string name) 
        {
            this.name = name;
        }
        internal abstract void Display(int depth);

    }
}
