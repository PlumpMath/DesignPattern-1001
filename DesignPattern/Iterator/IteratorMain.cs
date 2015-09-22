using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class IteratorMain
    {
        public void Execute()
        {
            Aggregate ca=new ConcreteAggregate();
            Iterator iterator = ca.GetIterator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.GetCurrent());
                iterator.Next();
            }
        }
    }
}
