using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_4
{
    //管理者
    class Caretaker
    {
        private Memento memento;
        //得到和设置备忘录
        public Memento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
