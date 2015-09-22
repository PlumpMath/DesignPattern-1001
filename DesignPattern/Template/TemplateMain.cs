using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    public class TemplateMain
    {
        public void Execute()
        {
            Console.WriteLine("请选择执行的功能：1.谷歌搜索 2.谷歌地图");
            string operation = Console.ReadLine();
            GoogleTemplate gt = null;
            if (operation=="1")
            {
                gt = new GoogleSearch();
            }
            else
            {
                gt = new GoogleMap();
            }
            gt.Google();
        }
    }
}
