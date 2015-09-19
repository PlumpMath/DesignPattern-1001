using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    /// <summary>
    /// 灯泡
    /// </summary>
    internal class Bulb
    {

        /// <summary>
        /// 点亮灯泡
        /// </summary>
        public void Illume() 
        {
            Console.WriteLine("点亮灯泡");

        }
        /// <summary>
        /// 熄灭灯泡
        /// </summary>
        public void Extinguish() 
        {
            Console.WriteLine("熄灭灯泡");
        }
    }
}
