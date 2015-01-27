using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_3
{
    class StockObserver:Observer
    {
        public StockObserver(string name, Secretary sec):base(name,sec)
        {
            this._name = name;
            this.sub = sec;
        }
        public override void Update()
        {
            Console.WriteLine("{0}{1}关闭股票，继续工作", sub.SecretaryAction, _name);
        }
    }
}
