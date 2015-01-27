using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//工厂方法模式
namespace DHMSP8
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory operFactory = new FactoryAdd();
            Operation oper = operFactory.CreateOperation();
            oper.NumberB = 9;
            oper.NumeberA = 27;
            double result = oper.GetResult();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
