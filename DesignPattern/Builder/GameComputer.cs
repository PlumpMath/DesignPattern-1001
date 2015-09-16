using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 游戏电脑
    /// </summary>
   internal class GameComputer:ComputerBuilder
    {
        private Computer computer = new Computer();
        internal override void SetupMainboard()
        {
            computer.Add("主板:华硕 Z97");
        }

        internal override void SetupCpu()
        {
            computer.Add("处理器:Inter I7");
        }

        internal override void SetupMemory()
        {
            computer.Add("内存条：金士顿 8G");
        }

        internal override void SetupHarddisk()
        {
            computer.Add("硬盘：西部数据 1T");
        }

        internal override void SetupVideocard()
        {
            computer.Add("显卡：影驰 GTX980");
        }

        internal override void SetupPower()
        {
            computer.Add("电源:海韵 550W");
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
