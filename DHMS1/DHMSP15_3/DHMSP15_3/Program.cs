using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//P15.3工厂方法模式的数据访问程序
namespace DHMSP15_3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IFactory factory = new SqlserverFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);
            Console.ReadLine();
        }
    }
}
