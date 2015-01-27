﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Secretary tongzijie = new Secretary();
            Boss huhansan = new Boss();

            StockObserver tongshi1 = new StockObserver("张三", huhansan);
            StockObserver tongshi2 = new StockObserver("李四", huhansan);
            NBAObserver tongshi3 = new NBAObserver("同事三", huhansan);

            huhansan.Attach(tongshi1);
            huhansan.Attach(tongshi2);
            huhansan.Attach(tongshi3);
            huhansan.Detach(tongshi2);

            huhansan.SecretaryAction = "我胡汉三回来了！";
            huhansan.Notify();



            Console.ReadLine();
        }
    }
}
