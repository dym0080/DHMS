﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_2
{
    class StockObserver
    {
        private string _name;
        private Secretary sub;

        public StockObserver(string name,Secretary sec)
        {
            this._name = name;
            this.sub = sec;
        }
        internal void Update()
        {
            Console.WriteLine("{0}{1}关闭股票，继续工作", sub.SecretaryAction, _name);
        }
    }
}
