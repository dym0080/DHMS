using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHMSP16_7
{
    /// <summary>
    /// 中午工作状态
    /// </summary>
    public class NoonState:State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点。饿了，午饭；困了，午休", w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}