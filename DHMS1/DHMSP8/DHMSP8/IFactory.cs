using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DHMSP8
{
    /// <summary>
    /// 抽象工厂接口
    /// </summary>
    interface IFactory
    {
        Operation CreateOperation();
    }
}
