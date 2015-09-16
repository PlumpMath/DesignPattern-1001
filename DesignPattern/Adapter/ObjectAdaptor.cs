using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    internal class ObjectAdaptor : ObjectSmallHeadsetPlug
    {
        ObjectBigHeadsetPlug shp = new ObjectBigHeadsetPlug();
        internal override void InsertSmallHeadsetPlug()
        {
            Console.Write("对象适配");
            shp.InsertBigHeadsetPlug();
        }
    }
}
