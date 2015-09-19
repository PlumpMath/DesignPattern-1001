using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    /// <summary>
    /// 开关
    /// </summary>
    internal class DerailingSwitch
    {
        internal bool turnState;
        public DerailingSwitch() 
        {
            turnState = false;
        }
        /// <summary>
        /// 打开开关
        /// </summary>
        public void TurnOn() 
        {
            Console.WriteLine("打开开关");
            turnState = true;
            
        }
        /// <summary>
        /// 关闭快关
        /// </summary>
        public void TurnOff()
        {
            Console.WriteLine("关闭开关");
            turnState = false;
        }
    }
}
