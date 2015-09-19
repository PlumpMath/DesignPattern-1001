using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class TurnOnState : WashingMachineState
    {
        internal override void Washing(WashingMachine wm)
        {
            Console.WriteLine("开始洗衣");
            wm.wmState = new InflowWaterState() ;
            wm.WashingMachineExecute();
        }
    }
}
