using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class FlyweightMain
    {
        public void Execute()
        {
            Cache cache = new Cache();
            FlyweightImage fi1 = cache.GetObject<Image>("图片1");
            fi1.Show("1");
            FlyweightImage fi2 = cache.GetObject<Image>("图片1");
            fi2.Show("2");
            Compare<FlyweightImage>(fi1,fi2,"1","2");
            FlyweightImage fi3 = cache.GetObject<Image>("图片2");
            fi3.Show("3");
            Compare<FlyweightImage>(fi1, fi3, "1", "3");
        }

        public void Compare<T>(T a, T b,string c,string d) where T :class
        {
            if (a==b)
            {
                Console.WriteLine("图片{0}和图片{1} 对象相同",c,d);
            }
            else
            {
                Console.WriteLine("图片{0}和图片{1} 对象不同", c, d);
            }
        }
    }
}
