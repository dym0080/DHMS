using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_4
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dep = new Department();
            //IFactory factory = new SqlserverFactory();
            IFactory factory = new AccessFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment idep = factory.CreateDepartment();
            idep.Insert(dep);
            idep.GetDepartment(1);
            Console.ReadLine();
        }
    }
}
