﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP2
{
    class CashFactory
    {
        public static CashSuper createCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case"正常收费":
                    cs = new CashNormal();
                    break;
                case"满300百送100":
                    cs = new CashReturn("300", "100");
                    break;
                case"打8折":
                    cs = new CashRebate("0.8");
                    break;
            }
            return cs;
        }
    }
}
