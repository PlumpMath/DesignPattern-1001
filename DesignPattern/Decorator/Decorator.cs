using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class Decorator:Person
    {
        private Person p;
        public Decorator(Person p) 
        {
            this.p = p;
        }
        internal override void Wear()
        {
            if (p!=null)
            {
                p.Wear();
            }
        }
    }
}
