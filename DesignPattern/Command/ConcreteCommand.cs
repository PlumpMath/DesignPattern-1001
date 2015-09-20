using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    /// <summary>
    /// 具体的命令
    /// </summary>
    internal class ConcreteCommand : Command
    {
        internal ConcreteCommand(Receiver receiver) 
            :base (receiver)
        {

        }
        public override void Action()
        {
            receiver.ExecuteCommand();
        }
    }
}
