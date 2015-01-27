using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHMSP16_7
{
    /// <summary>
    /// 下班休息状态
    /// </summary>
    public class RestState:State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点。下班了，回家", w.Hour);
        }
    }
}