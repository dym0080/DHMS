using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP23_4
{
    //抽象命令类
    public abstract class Command
    {
        protected Barbecuer receiver;
        //只需确定烤羊肉串者是谁
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }
        abstract public void ExcuteCommand();
    }
}
