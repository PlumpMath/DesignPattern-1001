using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    /// <summary>
    /// 工厂模式
    /// </summary>
    public class FactoryMain
    {
        public void Execute() 
        {
            Console.WriteLine("请选择Apple产品:1.Ipad 2.Iphone");
            string appleProduct=Console.ReadLine();
            ApplePrice ap;
            if (appleProduct=="1")
            {
                AppleStoreFactory asf = new IpadStoreFactory();
                Console.WriteLine("请选择Ipad:1.IpadMini 2.IpadAir");
                string ipadProduct = Console.ReadLine();
                ap=asf.CreateApplePriceFactory(ipadProduct == "1" ? "IpadMini" : "IpadAir");
                
            }
            else
            {
                AppleStoreFactory asf = new IphoneStoreFactory();
                Console.WriteLine("请选择Iphone:1.Iphone5 2.Iphone6");
                string iphoneProduct = Console.ReadLine();
                ap=asf.CreateApplePriceFactory(iphoneProduct == "1" ? "Iphone5" : "Iphone6");
            }
            ap.Price();
        }
    }
}
