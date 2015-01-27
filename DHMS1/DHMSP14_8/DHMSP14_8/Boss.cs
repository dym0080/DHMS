using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_8
{
    /// <summary>
    /// 前台秘书类
    /// </summary>
    class Boss : ISubject
    {
        
        //声明一个事件，类型为委托 EventHandler
        public event EventHandler Update;
        private string action;

        
        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            Update();
        }
        /// <summary>
        /// 前台状态
        /// </summary>
        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }
    }
}
