using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP23_4
{
    class Waiter
    {
        private Command command;
        //设置订单
        //服务员类，不管客户想要什么烤肉，反正都是‘命令’，只管记录
        //订单，然后通知‘烤肉者’执行即可
        public void SetOrder(Command command)
        {
            this.command = command;
        }
        //通知执行
        public void Notify()
        {
            command.ExcuteCommand();
        }
    }
}
