using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP9
{
    /// <summary>
    /// 原型类
    /// </summary>
    abstract class ProtoType
    {
        private string _id;

        public ProtoType(string id)
        {
            this._id = id;
        }

        public string ID
        {
            get { return _id; }
        }

        public abstract ProtoType Clone();
    }
}
