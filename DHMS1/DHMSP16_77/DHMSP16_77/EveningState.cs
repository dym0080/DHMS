using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHMSP16_7
{
    /// <summary>
    ///晚间工作状态
    /// </summary>
    public class EveningState:State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Finish)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 17)
                {
                    Console.WriteLine("当前时间：{0}点。下午工作状态还不错，继续努力", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }
}