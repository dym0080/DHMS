using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP19_5
{
    //人力资源部 树叶节点
    class HRDepartment:Company
    {
        public HRDepartment(string name):base(name)
        { }

        public override void Add(Company c)
        {
            
        }
        public override void Remove(Company c)
        {
            
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-',depth)+name);
        }
        public override void LineOfDuty()
        {
            Console.WriteLine("{0}员工招聘管理培训", name);
        }
    }
}
