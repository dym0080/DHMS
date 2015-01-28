using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP23_5
{
    class Waiter
    {
        //增加存放具体命令的容器
        private IList<Command> orders = new List<Command>();
        //设置订单
        //服务员类，不管客户想要什么烤肉，反正都是‘命令’，只管记录
        //订单，然后通知‘烤肉者’执行即可
        public void SetOrder(Command command)
        {
            if(command.ToString()=="DHMSP23_5.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤！");
            }
            else
            {
                //记录客户所点的烧烤的日志，以备算账收钱
                orders.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
            }
        }
        public void CancleOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());

        }
        //通知执行
        public void Notify()
        {
            //根据用户点好的订单通知厨房操作
            foreach (Command command in orders)
            {
                command.ExcuteCommand();
            }
        }
    }
}
