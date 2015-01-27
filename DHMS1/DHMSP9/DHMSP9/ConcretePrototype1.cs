using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP9
{
    /// <summary>
    /// 具体原型类
    /// </summary>
    class ConcretePrototype1:ProtoType
    {
        public ConcretePrototype1(string id)
            : base(id)
        { }

        public override ProtoType Clone()
        {
            return (ProtoType)this.MemberwiseClone();
        }
    }
}
