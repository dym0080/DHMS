using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_2
{
    /// <summary>
    /// 前台秘书类
    /// </summary>
    class Secretary
    {
        /// <summary>
        /// 同事列表
        /// </summary>
        private IList<StockObserver> observers = new List<StockObserver>();
        private string action;

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }
        /// <summary>
        /// 通知
        /// </summary>
        public void Notify()
        {
            foreach (StockObserver s in observers)
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
