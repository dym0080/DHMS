using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_3
{
    abstract class Observer
    {
        protected string _name;
        protected Secretary sub;

        public Observer(string name, Secretary sec)
        {
            this._name = name;
            this.sub = sec;
        }

        public abstract void Update();
    }
}
