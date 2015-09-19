using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class TurnOffState : WashingMachineState
    {
        internal override void Washing(WashingMachine wm)
        {
            Console.WriteLine("洗衣结束");
        }
    }
}
