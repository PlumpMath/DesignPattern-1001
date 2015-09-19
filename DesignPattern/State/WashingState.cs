using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class WashingState:WashingMachineState
    {
        internal override void Washing(WashingMachine wm)
        {
            Console.WriteLine("正在洗衣...");
            wm.wmState =new DischargeWaterState();
            wm.WashingMachineExecute();
        }
    }
}
