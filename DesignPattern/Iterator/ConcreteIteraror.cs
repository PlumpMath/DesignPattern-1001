using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    // 具体迭代器类
    public class ConcreteIteraror : Iterator
    {
        // 迭代器要集合对象进行遍历操作，自然就需要引用集合对象
        private ConcreteAggregate ca;
        private int index;
        public ConcreteIteraror(ConcreteAggregate ca) 
        {
            this.ca = ca;
            index = 0;
        }
        public bool MoveNext()
        {
            return index < ca.Length;
        }

        public object GetCurrent()
        {
            return ca.GetElement(this.index);
        }

        public void Next()
        {
            if (index<ca.Length)
            {
                index++;
            }
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
