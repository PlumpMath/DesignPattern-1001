using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    // 迭代器抽象类
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }
}
