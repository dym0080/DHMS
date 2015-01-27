using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_4
{
    class SqlserverUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL server中给表USER新增一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在sql server中根据id获得user表中一条数据");
            return null;
        }
    }
}
