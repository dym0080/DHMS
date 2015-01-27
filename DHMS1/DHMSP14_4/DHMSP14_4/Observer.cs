using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_4
{
    abstract class Observer
    {
        protected string _name;
        protected ISubject sub;

        public Observer(string name, ISubject sec)
        {
            this._name = name;
            this.sub = sec;
        }

        public abstract void Update();
    }
}
