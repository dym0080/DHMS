using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_8
{
    delegate void EventHandler();
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();

            StockObserver tongshi1 = new StockObserver("张三", huhansan);
            StockObserver tongshi2 = new StockObserver("李四", huhansan);
            NBAObserver tongshi3 = new NBAObserver("同事三", huhansan);

            huhansan.Update += new EventHandler(tongshi1.CloseStockMarket);
            huhansan.Update += new EventHandler(tongshi2.CloseStockMarket);
            huhansan.Update += new EventHandler(tongshi3.CloseNBAVideo);

            huhansan.SecretaryAction = "我胡汉三回来了！";
            huhansan.Notify();



            Console.ReadLine();
        }
    }
}
