using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_4
{
    //发起人
    class Originator
    {
        //需要保存数据的属性，可以有多个
        private string state;
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        //创建备忘录，将当前需要保存的信息导入并实例化出一个Memnto对象
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        //恢复备忘录，将Memnto导入并将相关数据恢复
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }
        //显示数据
        public void Show()
        {
            Console.WriteLine("State=" + state);
        }
    }
}
