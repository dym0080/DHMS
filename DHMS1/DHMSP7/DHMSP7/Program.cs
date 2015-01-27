using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//代理模式
namespace DHMSP7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  P7.2
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            Pursuit zhuojiayi = new Pursuit(jiaojiao);

            zhuojiayi.GiveFlows();
            zhuojiayi.GiveDolls();
            zhuojiayi.GiveChocolate();

            Console.ReadLine();
             */

            //P7.2
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";

            Poxy daili = new Poxy(jiaojiao);

            daili.GiveFlows();
            daili.GiveDolls();
            daili.GiveChocolate();

            Console.ReadLine();
             
        }
    }

    
}
