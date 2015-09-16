using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    public class SimpleFactoryMain
    {
        public void Execute() 
        {
            Console.WriteLine("请选择Iphone:1.Iphone5 2.Iphone6");
            string str= Console.ReadLine();
            IphonePrice ip = IphoneStoreFactory.CreateIphonePrice(str == "1" ? "Iphone5" : "Iphone6");
            ip.Price();
        }
    }
}
