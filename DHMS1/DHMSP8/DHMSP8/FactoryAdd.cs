using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP8
{
    /// <summary>
    /// 加法工厂
    /// </summary>
    class FactoryAdd:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
}
