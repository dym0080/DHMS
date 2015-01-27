using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHMSP16_7
{
    /// <summary>
    /// 工作类
    /// </summary>
    public class Work
    {
        private State current;

        public Work()
        {
            current = new ForenoonState();
        }

        private double hour;
        /// <summary>
        /// 钟点
        /// </summary>
        public double Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        private bool finish = false;
        /// <summary>
        /// 任务是否完成
        /// </summary>
        public bool Finish
        {
            get { return finish; }
            set { finish = value; }
        }

        public void SetState(State s)
        {
            current = s;
        }

        public void WriteProgram()
        {
            current.WriteProgram(this);
        }
    }
}