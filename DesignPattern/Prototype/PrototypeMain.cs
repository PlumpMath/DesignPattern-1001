using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    /// <summary>
    /// 原型模式
    /// </summary>
    public class PrototypeMain
    {
        public void Execute()
        {
            //浅克隆：创建新的对象，指向老对象的值
            //深克隆: 创建新的对象，指向新创建的老对象的值
            Console.WriteLine("请选择克隆方式：1.浅克隆 2.深克隆");
            string cloneType = Console.ReadLine();

            AbstractPrototype prototype,copy;
            prototype = new ConcretePrototype();
            
            if (cloneType=="1")
                copy=prototype.ShallowClone();
            else
                copy = prototype.DeepClone();
            Console.WriteLine("对象是否相同" + (prototype == copy));
            Console.WriteLine("值是否相同" + (prototype.entity == copy.entity));
        }
    }
}
