using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP8
{
    /// <summary>
    /// 除法工厂
    /// </summary>
    class FactoryDiv : IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
