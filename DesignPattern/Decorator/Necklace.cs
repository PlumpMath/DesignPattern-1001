using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class Necklace:Decorator
    {
        public Necklace(Person p) :base(p)
        {

        }
        internal override void Wear()
        {
            base.Wear();
            AddNewDecorator();
        }
        private void AddNewDecorator() 
        {
            Console.WriteLine("佩戴项链");
        }
    }
}
