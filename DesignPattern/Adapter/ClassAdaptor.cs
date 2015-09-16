using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    internal class ClassAdaptor : ClassBigHeadsetPlug,ClassSmallHeadsetPlug
    {
        public void InsertSmallHeadsetPlug()
        {
            Console.Write("类适配");
            this.InsertBigHeadsetPlug();
        }
    }
}
