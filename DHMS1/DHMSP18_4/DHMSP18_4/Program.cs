using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Originator初始状态，状态属性为“on”
            Originator o = new Originator();
            o.State = "On";
            o.Show();

            //保存状态时，由于有了很好的封装性，可以隐藏Originator的实现细节
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            //Originator改变了状态属性为“off”
            o.State = "Off";
            o.Show();

            //恢复初始状态
            o.SetMemento(c.Memento);
            o.Show();

            Console.Read();
        }
    }
}
