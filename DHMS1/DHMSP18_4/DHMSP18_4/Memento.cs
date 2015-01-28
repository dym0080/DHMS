using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP18_4
{
    //备忘录
    class Memento
    {
        private string state;
        public string State
        {
            //需要保存数据的属性，可以是多个
            get { return state; }
        }
        /// <summary>
        /// 构造方法，将相关数据导入
        /// </summary>
        /// <param name="state"></param>
        public Memento(string state)
        {
            this.state = state;
        }
    }
}
