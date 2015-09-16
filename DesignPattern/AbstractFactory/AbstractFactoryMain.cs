using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 抽象工厂模式
    /// </summary>
    public class AbstractFactoryMain
    {
        public void Execute()
        {
            Console.WriteLine("请选择产品：1.Iphone 2.Ipad");
            string productNumber = Console.ReadLine();
            AppleFactory af=null;
            if (productNumber=="1")
            {
                af = new IphoneFactory();
            }
            else
            {
                af = new IpadFactory();
            }
            af.CreateProductSize().Size();
            af.CreateProductPrice().Price();
        }
    }
}
