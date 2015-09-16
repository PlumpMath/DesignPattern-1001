using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 抽象类，给出必须筑造的原件类型
    /// </summary>
    internal abstract class ComputerBuilder
    {
        internal abstract void SetupMainboard();
        internal abstract void SetupCpu();
        internal abstract void SetupMemory();
        internal abstract void SetupHarddisk();
        internal abstract void SetupVideocard();
        internal abstract void SetupPower();
        /// <summary>
        /// 返回各种原件
        /// </summary>
        /// <returns>返回各种原件</returns>
        internal abstract Computer ResultComputer();
    }
}
