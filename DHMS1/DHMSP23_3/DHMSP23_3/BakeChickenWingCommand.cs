using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP23_4
{
    //具体命令类：烤鸡翅类
    class BakeChickenWingCommand:Command
    {
        public BakeChickenWingCommand(Barbecuer receiver)
            :base(receiver)
        { }
        public override void ExcuteCommand()
        {
            receiver.BakeChickenWing();
        }
    }
}
