using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// 桥接模式
    /// </summary>
    public class BridgeMain 
    {
        public void Execute()
        {
            Console.WriteLine("选择系统：1.Ios 2.Android");
            string systemType = Console.ReadLine();
            System system = null ;
            if (systemType=="1")
                system = new IosSystem();
            else
                system = new AndroidSystem();
            system.SetApps(new GameApp());
            system.Run();
            system.SetApps(new SocialApp());
            system.Run();
        }
    }
}
