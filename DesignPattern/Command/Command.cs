using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
    internal abstract class Command
    {
        internal Receiver receiver;
        internal Command(Receiver receiver) 
        {
            this.receiver = receiver;
        }
        public abstract void Action();
    }
}
