using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP23_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //开店前的准备
            Barbecuer boy = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boy);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boy);
            Command bakeChickenWingCommand = new BakeChickenWingCommand(boy);
            Waiter gril = new Waiter();

            //开门营业
            gril.SetOrder(bakeMuttonCommand1);
            gril.Notify();
            gril.SetOrder(bakeMuttonCommand2);
            gril.Notify();
            gril.SetOrder(bakeChickenWingCommand);
            gril.Notify();

            Console.Read();
        }
    }
}
