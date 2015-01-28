using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP17_4
{
    class Forwards:Player
    {
        public Forwards(string name):base (name)
        { }

        public override void Attack()
        {
            Console.WriteLine("前锋{0}进攻", _name);
        }

        public override void Defense()
        {
            Console.WriteLine("前锋{0}防守", _name);
        }
    }
}
