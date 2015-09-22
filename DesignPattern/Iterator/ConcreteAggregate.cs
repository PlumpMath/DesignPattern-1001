using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        int[] collection;
        public ConcreteAggregate() 
        {
            collection=new int[]{2,4,6,8};
        }
        public Iterator GetIterator()
        {
            return new ConcreteIteraror(this);
        }
        public int Length 
        {
            get { return collection.Length; }
        }
        public int GetElement(int index) 
        {
            return collection[index];
        }
    }
}
