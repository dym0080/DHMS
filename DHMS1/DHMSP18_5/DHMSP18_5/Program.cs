using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //大战BOSS前
            GameRole lixiaoyao = new GameRole();
            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保存进度
            RoleSateCaretaker stateAdmin = new RoleSateCaretaker();
            stateAdmin.Memento = lixiaoyao.SaveSate();

            //大战BOSS，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前的状态
            lixiaoyao.RecoverySate(stateAdmin.Memento);
            lixiaoyao.StateDisplay();

            Console.Read();
        }
    }
}
