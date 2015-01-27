using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_8
{
    class NBAObserver
    {
        private string _name;
        private ISubject sub;
        public NBAObserver(string name, ISubject sec)
        {
            this._name = name;
            this.sub = sec;
        }

        public  void CloseNBAVideo() 
        {
            Console.WriteLine("{0}{1}关闭NBA直播，继续工作", sub.SecretaryAction, _name);
        }
    }
}
