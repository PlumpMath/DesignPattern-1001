﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    internal class IpadAirPrice:ApplePrice
    {
        internal override void Price()
        {
            Console.WriteLine("IpadAir售价：4288");
        }
    }
}
