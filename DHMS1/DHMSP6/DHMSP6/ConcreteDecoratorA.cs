using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP6
{
    class ConcreteDecoratorA : Decorator
    {
        private string addedstate;
        public override void Operation()
        {
            base.Operation();
            addedstate = "New state";
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
}
