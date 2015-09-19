using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class DischargeWaterState:WashingMachineState
    {
        internal override void Washing(WashingMachine wm)
        {
            Console.WriteLine("正在放出水...");
            wm.wmState = new Spin_dryState();
            wm.WashingMachineExecute();
        }
    }
}
