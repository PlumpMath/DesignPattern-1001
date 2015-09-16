using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class AdapterMain
    {
        public void Execute()
        {
            
            Console.WriteLine("请选择适配器:1.类适配器 2.对象适配器");
            string adapterName = Console.ReadLine();
            //已有粗孔耳机插头  需要插入细孔的插槽
            if (adapterName=="1")
            {
                ClassSmallHeadsetPlug shp = new ClassAdaptor();
                shp.InsertSmallHeadsetPlug();
            }
            else
            {
                ObjectSmallHeadsetPlug shp = new ObjectAdaptor();
                shp.InsertSmallHeadsetPlug();
            }
        }
    }
}
