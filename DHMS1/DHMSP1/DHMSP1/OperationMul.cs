using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP1
{
    class OperationMul : Operation
    {
        public override double getResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
