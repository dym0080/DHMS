﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP22_6
{
    class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
