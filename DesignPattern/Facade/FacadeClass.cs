using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    internal class FacadeClass
    {
        
        private Bulb bulb;
        private DerailingSwitch ds;
        internal FacadeClass() 
        {
            bulb = new Bulb();
            ds = new DerailingSwitch();
        }
        internal void Turn() 
        {
            if (!ds.turnState)
            {
                ds.TurnOn();
                bulb.Illume();
            }
            else
            {
                ds.TurnOff();
                bulb.Extinguish();
            }
        }
    }
}
