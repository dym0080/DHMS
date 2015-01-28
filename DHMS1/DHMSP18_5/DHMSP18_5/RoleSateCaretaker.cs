using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_5
{
    //角色状态管理类
    class RoleSateCaretaker
    {
        private RoleStateMemento memento;
        public RoleStateMemento Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
