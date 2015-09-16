using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    /// <summary>
    /// 建造者模式
    /// </summary>
    public class BuilderMain
    {
        public void Execute()
        {
            Console.WriteLine("请选择组装的电脑：1.办公电脑 2.游戏电脑");
            string computernNumber = Console.ReadLine();
            if (computernNumber=="1")
            {
                Console.WriteLine("-------正在装载办公电脑---------");
                //装载的对象
                ComputerBuilder cb= new WorkComputer();
                //装载流程
                ComputerStore cs = new ComputerStore();
                //按照装载流程执行装载
                cs.Assemble(cb);
                //把装载好的电脑返回给复杂对象的电脑
                Computer computer = cb.ResultComputer();
                //为显示而写，实际中可忽略
                computer.Setup();
                Console.WriteLine("-------成功装载办公电脑---------");
            }
            else
            {
                Console.WriteLine("-------正在装载游戏电脑---------");
                ComputerStore cs = new ComputerStore();
                ComputerBuilder cb = new GameComputer();
                cs.Assemble(cb);
                Computer computer = cb.ResultComputer();
                computer.Setup();
                Console.WriteLine("-------成功装载游戏电脑---------");
            }
        }
    }
}
