using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP20_3
{
    //聚集抽象类
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
