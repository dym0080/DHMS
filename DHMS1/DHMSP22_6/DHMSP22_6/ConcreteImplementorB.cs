using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP22_6
{
    class ConcreteImplementorB:Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现B的方法的执行");
        }
    }
}
