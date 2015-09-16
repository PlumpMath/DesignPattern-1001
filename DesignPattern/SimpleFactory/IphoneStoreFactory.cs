using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    internal class IphoneStoreFactory
    {
        internal static IphonePrice CreateIphonePrice(string type) 
        {
            IphonePrice ip=null;
            switch (type)
            {
                case "Iphone5":
                    ip= new Iphone5Price();
                     break;
                case "Iphone6":
                   ip= new Iphone6Price();
                    break;
                default:
                    break;
            }
            if (ip==null)
                throw new Exception();
            return ip;
            
        }
    }
}
