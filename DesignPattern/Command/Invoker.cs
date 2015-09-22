using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    /// <summary>
    /// 请求命令
    /// </summary>
    internal class Invoker
    {
        internal Command cmd;
        internal Invoker(Command cmd) 
        {
            this.cmd = cmd;
        }
        internal void ExecuteCommand() 
        {
            cmd.Action();
        }
    }
}
