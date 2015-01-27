using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_4
{
    /// <summary>
    /// 前台秘书类
    /// </summary>
    class Boss : ISubject
    {
        /// <summary>
        /// 同事列表
        /// </summary>
        private IList<Observer> observers = new List<Observer>();
        private string action;

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (Observer s in observers)
                s.Update();
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
