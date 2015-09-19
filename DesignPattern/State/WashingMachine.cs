using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    internal class WashingMachine
    {
        private WashingMachineState _wmState;

        internal WashingMachineState wmState
        {
            get { return _wmState; }
            set { _wmState = value; }
        }
        internal void WashingMachineExecute() 
        {
            wmState.Washing(this);
        }
        public WashingMachine() 
        {
            _wmState = new TurnOnState();
        }
    }
}
