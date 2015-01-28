using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP20_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> a = new List<string>();
            a.Add("大鸟");
            a.Add("小菜");
            a.Add("行李");
            a.Add("老外");
            a.Add("公司内部员工");
            a.Add("小偷");
            foreach (string item in a)
            {
                Console.WriteLine("{0}请买票", item);
            }
            Console.Read();

            IEnumerator<string> e = a.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine("{0}请买票", e.Current);
            }
            
        }
        
        
        public interface 
    }


}
