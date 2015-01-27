using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP8
{
    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0");
            result = NumeberA / NumberB;
            return result;
        }
    }
}
