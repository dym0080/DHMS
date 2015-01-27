﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP1
{
    class OperationDiv : Operation
    {
        public override double getResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0");
            result = NumberA / NumberB;
            return result;
        }
    }
}
