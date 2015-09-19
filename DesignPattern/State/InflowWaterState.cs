using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class InflowWaterState:WashingMachineState
    {
        internal override void Washing(WashingMachine wm)
        {
            Console.WriteLine("正在放入水...");
            wm.wmState = new WashingState();
            wm.WashingMachineExecute();
        }
    }
}
