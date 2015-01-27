using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHMSP16_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();
            work.Hour = 10;
            work.WriteProgram();
            work.Hour = 12;
            work.WriteProgram();
            work.Hour = 13;
            work.WriteProgram();
            work.Hour = 14;
            work.WriteProgram();
            work.Hour = 17;
            work.WriteProgram();

            work.Finish = true;
            work.Hour = 19;
            work.WriteProgram();
            work.Hour = 22;
            work.WriteProgram();

            Console.ReadLine();
        }
    }
}
