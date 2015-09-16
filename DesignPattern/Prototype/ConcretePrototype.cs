using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// AbstractPrototype:实现虚拟原型方法
    /// ICloneable:实现克隆接口
    /// </summary>
    internal class ConcretePrototype : AbstractPrototype, ICloneable 
    {
        /// <summary>
        /// 浅克隆
        /// </summary>
        /// <returns></returns>
        internal override AbstractPrototype ShallowClone()
        {
            AbstractPrototype cp = new ConcretePrototype();
            cp.entity = this.entity;
            return cp;
        }
        /// <summary>
        /// 深克隆
        /// </summary>
        /// <returns></returns>
        internal override AbstractPrototype DeepClone()
        {
            return Clone() as AbstractPrototype;
        }

        #region ICloneable 成员

        public object Clone()
        {
            AbstractPrototype ap = (AbstractPrototype)this.MemberwiseClone();
            Entity newEntity = new Entity();
            ap.entity = newEntity;
            return ap;
        }

        #endregion
    }
}
