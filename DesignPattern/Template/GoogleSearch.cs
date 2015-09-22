using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    internal class GoogleSearch:GoogleTemplate
    {
        protected override void Operation()
        {
            Console.WriteLine("打开谷歌搜索");
        }
    }
}
