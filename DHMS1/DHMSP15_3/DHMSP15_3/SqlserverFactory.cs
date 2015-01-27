using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_3
{
    class SqlserverFactory:IFactory
    {
        public IUser CreateUser()
        {
            return new SqlserverUser();
        }
    }
}
