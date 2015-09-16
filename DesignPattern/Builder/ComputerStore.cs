using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    internal class ComputerStore
    {
        /// <summary>
        /// 建造流程
        /// </summary>
        /// <param name="cb">建造的各种原件</param>
        internal void Assemble(ComputerBuilder cb) 
        {
            cb.SetupMainboard();
            cb.SetupCpu();
            cb.SetupMemory();
            cb.SetupHarddisk();
            cb.SetupVideocard();
            cb.SetupPower();
        }
    }
}
