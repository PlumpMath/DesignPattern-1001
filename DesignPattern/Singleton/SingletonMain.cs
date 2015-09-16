using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    public class SingletonMain
    {
        public void Execute()
        {
            FruitStore.GetInstance().ListOfFruits();
        }
    }
}
