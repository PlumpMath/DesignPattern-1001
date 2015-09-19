using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class Spin_dryState:WashingMachineState
    {
        internal override void Washing(WashingMachine wm)
        {
            Console.WriteLine("正在甩干...");
            wm.wmState = new TurnOffState();
            wm.WashingMachineExecute();
        }
    }
}
