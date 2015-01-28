using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_5
{
    //游戏角色类
    class GameRole
    {
        private int vit;
        private int atk;
        private int def;
        //生命力
        public int Vitality
        { 
            get { return vit; }
            set { vit = value; }
        }
        //攻击力
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }
        //防御力
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }
        // 保存游戏状态
        public　RoleStateMemento SaveSate()
        {
            return(new RoleStateMemento(vit,atk,def));
        }
        //恢复游戏状态
        public void RecoverySate(RoleStateMemento memento)
        {
            this.vit = memento.Vitality;
            this.atk = memento.Attack;
            this.def = memento.Defense;
        }
        //显示
        public void StateDisplay()
        {
            Console.WriteLine("当前的角色状态：");
            Console.WriteLine("体力：{0}", this.vit);
            Console.WriteLine("攻击力：{0}", this.atk);
            Console.WriteLine("防御力：{0}", this.def);
            Console.WriteLine("");

        }
        //获取初始状态
        public void GetInitState()
        {
            this.atk = 100;
            this.def = 100;
            this.vit = 100;
        }
        //战斗
        public void Fight()
        {
            this.atk = 0;
            this.def = 0;
            this.vit = 0;
        }
    }
}
