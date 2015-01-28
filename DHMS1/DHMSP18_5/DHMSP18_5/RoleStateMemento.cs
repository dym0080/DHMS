using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_5
{
    //角色状态存储箱
    class RoleStateMemento
    {
        private int vit;
        private int atk;
        private int def;
        //构造函数，将生命力，攻击力，防御力保存于状态存储箱对象（备忘录对象）中
        public RoleStateMemento(int vit,int atk,int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }
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
    }
}
