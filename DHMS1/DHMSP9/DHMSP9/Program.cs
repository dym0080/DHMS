using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//原型模式
namespace DHMSP9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 9.2
            //Resume a = new Resume("大鸟");
            //a.SetPersonalInfo("男", "29");
            //a.SetWorkExperience("1998-2002", "xx软件公司");

            //Resume b = a;
            //Resume c = a;

            //a.Display();
            //b.Display();
            //c.Display();

            //Console.ReadLine();
            #endregion

            #region 9.3
            //ConcretePrototype1 p1 = new ConcretePrototype1("I");
            //ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            //Console.WriteLine("Cloned:{0}", c1.ID);
            //Console.ReadLine();
            #endregion

            #region 9.4
            //Resume2 a = new Resume2("大鸟");
            //a.SetPersonalInfo("男", "29");
            //a.SetWorkExperience("1998-2002", "xx软件公司");

            //Resume2 b = (Resume2)a.Clone();
            //b.SetPersonalInfo("男", "25");

            //Resume2 c = (Resume2)a.Clone();
            //a.SetWorkExperience("1998-2002", "yyyy软件公司");

            //a.Display();
            //b.Display();
            //c.Display();

            //Console.ReadLine();
            #endregion

            #region 9.5
            //Resume3 a = new Resume3("大鸟");
            //a.SetPersonalInfo("男", "29");
            //a.SetWorkExperience("1998-2002", "xx软件公司");

            //Resume3 b = (Resume3)a.Clone();
            //b.SetWorkExperience("1998-2002", "yy软件公司");

            //Resume3 c = (Resume3)a.Clone();
            //c.SetWorkExperience("1998-2002", "zz软件公司");

            //a.Display();
            //b.Display();
            //c.Display();

            //Console.ReadLine();
            #endregion

            #region 9.6
            Resume4 a = new Resume4("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2002", "xx软件公司");

            Resume4 b = (Resume4)a.Clone();
            b.SetWorkExperience("1998-2002", "yy软件公司");

            Resume4 c = (Resume4)a.Clone();
            c.SetWorkExperience("1998-2002", "zz软件公司");

            a.Display();
            b.Display();
            c.Display();

            Console.ReadLine();
            #endregion


        }
    }
}
