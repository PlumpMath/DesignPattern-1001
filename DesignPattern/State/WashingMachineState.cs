using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal abstract class WashingMachineState
    {
        internal abstract void Washing(WashingMachine wm);
    }
}
