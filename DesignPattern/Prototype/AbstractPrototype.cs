using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// 虚拟原型类
    /// </summary>
    internal abstract class AbstractPrototype
    {
        public Entity entity{get;set;}
        internal abstract AbstractPrototype ShallowClone();
        internal abstract AbstractPrototype DeepClone();
    }
}
