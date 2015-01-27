using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_3
{
    class NBAObserver:Observer
    {
        public NBAObserver(string name,Secretary sec):base(name,sec)
        { }

        public override void Update()
        {
            Console.WriteLine("{0}{1}关闭NB直播，继续工作", sub.SecretaryAction, _name);
        }
    }
}
