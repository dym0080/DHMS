using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP17_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player b = new Forwards("巴蒂尔");
            b.Attack();

            Player m = new Guards("麦格雷迪");
            m.Attack();

            Player ym = new Guards("姚明");
            ym.Attack();
            ym.Defense();

            Console.Read();
        }
    }
}
