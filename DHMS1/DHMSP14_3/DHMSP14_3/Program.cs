using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Secretary tongzijie = new Secretary();


            StockObserver tongshi1 = new StockObserver("张三", tongzijie);
            StockObserver tongshi2 = new StockObserver("李四", tongzijie);
            NBAObserver tongshi3 = new NBAObserver("同事三", tongzijie);

            tongzijie.Attach(tongshi1);
            tongzijie.Attach(tongshi2);
            tongzijie.Attach(tongshi3);

            tongzijie.SecretaryAction = "老板回来了！";
            tongzijie.Notify();



            Console.ReadLine();
        }
    }
}
