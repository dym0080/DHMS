using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DHMSP16_7
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }
}