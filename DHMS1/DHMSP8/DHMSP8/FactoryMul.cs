using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP8
{
    /// <summary>
    /// 乘法工厂
    /// </summary>
    class FactoryMul:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
}
