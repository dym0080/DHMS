using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMS16_5
{
    abstract class State
    {
        public abstract void Handle(Context context);
    }
}
