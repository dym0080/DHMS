using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP8
{
    /// <summary>
    /// 减法工厂
    /// </summary>
    class FactorySub:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
}
