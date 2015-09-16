using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    internal class FruitStore
    {
        private static FruitStore fsInstance;
        //多线程下使用
        //private static object _lock = new object();
        private FruitStore() 
        {

        }
        public static FruitStore GetInstance() 
        {
            //多线程下使用
            //if (fsInstance==null)
            //{
                
                //lock (_lock)
                //{
                        if (fsInstance == null)
                        {
                            fsInstance = new FruitStore();
                        }
                //}
            //}
            return fsInstance;
        }
        public void ListOfFruits() 
        {
            Console.WriteLine("水果列表：");
            Console.WriteLine("     香蕉：3￥/kg");
            Console.WriteLine("     苹果：5￥/kg");
        }
    }
}
