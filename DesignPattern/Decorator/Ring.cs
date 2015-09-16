using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    internal class Ring:Decorator
    {
        public Ring(Person p) : base(p) 
        {
        }
        internal override void Wear()
        {
            base.Wear();
            AddNewDecorator();
        }
        private void AddNewDecorator() 
        {
            Console.WriteLine("佩戴戒指");
        }
    }
}
