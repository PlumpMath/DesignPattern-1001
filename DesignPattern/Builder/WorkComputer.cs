using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 工作电脑
    /// </summary>
    internal class WorkComputer:ComputerBuilder
    {
        private Computer computer = new Computer();
        internal override void SetupMainboard()
        {
            computer.Add("主板:华硕 B85");
        }

        internal override void SetupCpu()
        {
            computer.Add("处理器:Inter I5");
        }

        internal override void SetupMemory()
        {
            computer.Add("内存条：金士顿 4G");
        }

        internal override void SetupHarddisk()
        {
            computer.Add("硬盘：西部数据 500G");
        }

        internal override void SetupVideocard()
        {
            computer.Add("显卡：影驰 GTX650");
        }

        internal override void SetupPower()
        {
            computer.Add("电源:海韵 430W");
        }

        /// <summary>
        /// 返回各个原件
        /// </summary>
        /// <returns>返回各个原件</returns>
        internal override Computer ResultComputer()
        {
            return computer;
        }
    }
}
