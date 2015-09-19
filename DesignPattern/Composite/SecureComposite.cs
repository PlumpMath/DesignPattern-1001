using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    internal class SecureComposite : SecureComponet
    {
        private List<SecureComponet> list = new List<SecureComponet>();
        internal SecureComposite(string name)
            : base(name)
        {
        }
        internal override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var item in list)
            {
                item.Display(depth + 2);
            }
        }
        internal void Add(SecureComponet sc)
        {
            list.Add(sc);
        }
        internal void Remove(SecureComponet sc) 
        {
            list.Remove(sc);
        }
    }
}
