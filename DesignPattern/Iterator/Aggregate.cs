using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    // 抽象聚合类
    public interface Aggregate
    {
        Iterator GetIterator();
    }
}
