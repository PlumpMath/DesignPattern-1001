using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    public class CommandMain
    {
        public void Execute()
        {
            Receiver receiver = new Receiver();
            ConcreteCommand cc = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker(cc);
            invoker.cmd.Action();
        }
    }
}
