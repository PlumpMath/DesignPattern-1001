using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class FacadeMain
    {
        public void Execute()
        {
            FacadeClass fs = new FacadeClass();
            fs.Turn();
            fs.Turn();
        }
    }
}
