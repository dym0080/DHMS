using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP7
{
    /// <summary>
    /// 追求者类
    /// </summary>
    class Pursuit
    {
        SchoolGirl mm;

        public Pursuit(SchoolGirl m)
        {
            this.mm = m;
        }

        public void GiveFlows()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你洋娃娃");
        }
    }
}
