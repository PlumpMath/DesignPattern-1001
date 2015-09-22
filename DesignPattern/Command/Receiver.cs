using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    /// <summary>
    /// 命令接收者
    /// </summary>
    internal class Receiver
    {
        /// <summary>
        /// 执行命令
        /// </summary>
        public void ExecuteCommand()
        {
            Console.WriteLine("执行命令");
        }
    }
}
