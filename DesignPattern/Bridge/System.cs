using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    internal abstract class System
    {
        public Apps apps;
        public void SetApps(Apps apps) 
        {
            this.apps = apps;
        }
        internal abstract void Run();
    }
}
