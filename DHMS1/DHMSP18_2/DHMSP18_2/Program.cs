using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameRole lixiaoyao = new GameRole();

            lixiaoyao.GetInitState();
            lixiaoyao.StateDisplay();

            //保持进度
            GameRole backup = new GameRole();
            backup.Vitality = lixiaoyao.Vitality;
            backup.Attack = lixiaoyao.Attack;
            backup.Defense = lixiaoyao.Defense;

            //大战boss时，损耗严重
            lixiaoyao.Fight();
            lixiaoyao.StateDisplay();

            //恢复之前保存的数据
            lixiaoyao.Vitality = backup.Vitality;
            lixiaoyao.Attack = backup.Attack;
            lixiaoyao.Defense = backup.Defense;

            lixiaoyao.StateDisplay();
            Console.Read();
        }
    }
}

