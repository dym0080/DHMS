using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP17_4
{
    /// <summary>
    /// 球员类
    /// </summary>
    abstract class Player
    {
        protected string _name;
        public Player(string name)
        {
            this._name = name;
        }
        /// <summary>
        /// 进攻
        /// </summary>
        public abstract void Attack();
        /// <summary>
        /// 防守
        /// </summary>
        public abstract void Defense();
    }
}
