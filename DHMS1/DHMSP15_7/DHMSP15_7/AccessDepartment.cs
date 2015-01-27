using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_9
{
    class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给表Department新增一条记录");
        }
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根据id获得Department表中一条数据");
            return null;
        }
    }
}
