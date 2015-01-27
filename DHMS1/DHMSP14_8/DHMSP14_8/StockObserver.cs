using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_8
{
    class StockObserver
    {

        private string _name;
        private ISubject sub;
        public StockObserver(string name, ISubject sec)
        {
            this._name = name;
            this.sub = sec;
        }
        public  void CloseStockMarket()
        {
            Console.WriteLine("{0}{1}关闭股票，继续工作", sub.SecretaryAction, _name);
        }
    }
}
