using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_9
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dep = new Department();
            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment idep = DataAccess.CreateDepartment();
            idep.Insert(dep);
            idep.GetDepartment(1);
            Console.ReadLine();
        }
    }
}
