using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHMSP16_7
{
    /// <summary>
    /// 睡眠状态
    /// </summary>
    public class SleepingState:State    
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点。不行了，睡觉了",w.Hour);
        }
    }
}