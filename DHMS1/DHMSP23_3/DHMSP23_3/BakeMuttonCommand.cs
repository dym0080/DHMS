﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP23_4
{
    //具体命令类：烤羊肉串命令
    class BakeMuttonCommand:Command
    {
        public BakeMuttonCommand(Barbecuer receiver)
            :base(receiver)
        {}

        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }
}
