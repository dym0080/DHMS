using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_2
{
    /// <summary>
    /// 游戏角色类
    /// </summary>
    class GameRole
    {
        /// <summary>
        /// 生命力
        /// </summary>
        private int vit;
        public int Vitality
        {
            get { return vit; }
            set
            {
                vit = value;
            }
        }
        /// <summary>
        /// 攻击力
        /// </summary>
        private int atk;
        public int Attack
        {
            get { return atk; }
            set
            {
                atk = value;
            }
        }
        /// <summary>
        /// 防御力
        /// </summary>
        private int def;
        public int Defense
        {
            get { return def; }
            set
            {
                def = value;
            }
        }
        /// <summary>
        /// 状态显示
        /// </summary>
        public void StateDisplay()
        {
            Console.WriteLine("当前的角色状态：");
            Console.WriteLine("体力：{0}", this.vit);
            Console.WriteLine("攻击力：{0}", this.atk);
            Console.WriteLine("防御力：{0}", this.def);
            Console.WriteLine("");

        }
        /// <summary>
        /// 获取初始状态
        /// </summary>
        public void GetInitState()
        {
            this.atk = 100;
            this.def = 100;
            this.vit = 100;
        }
        /// <summary>
        /// 战斗
        /// </summary>
        public void Fight()
        {
            this.atk = 0;
            this.def = 0;
            this.vit = 0;
        }
    }
}
