using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//策略模式
namespace DHMSP6
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponet c = new ConcreteComponet();
            ConcreteDecoratorA dA = new ConcreteDecoratorA();
            ConcreteDecoratorB dB = new ConcreteDecoratorB();

            dA.SetComponent(c);
            dB.SetComponent(dB);
            dB.Operation();

            Console.Read();
        }
    }
}
