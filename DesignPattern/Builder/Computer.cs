using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 要创建的复杂对象的电脑
    /// </summary>
    internal class Computer
    {
        //储存原件
        IList<string> parts = new List<string>();
        internal void Add(string part) 
        {
            parts.Add(part);
        }
        internal void Setup() 
        {
            foreach (var item in parts)
            {
                Console.WriteLine("正在装载" + item + " --已完成");
            }
        }
    }
}
