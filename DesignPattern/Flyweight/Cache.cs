using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Flyweight
{
    /// <summary>
    /// 储存器
    /// </summary>
    internal class Cache
    {
        private Hashtable ht=new Hashtable ();

        public T GetObject<T>(string name) where T:class,new()
        {
            if (!ht.ContainsKey(name))
            {
                ht.Add(name, new T());
                
            }
            return ht[name] as T;
        }
    }
}
