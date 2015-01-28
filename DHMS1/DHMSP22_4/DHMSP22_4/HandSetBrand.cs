using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP22_4
{
    //手机品牌
    abstract class HandSetBrand
    {
        protected HandSetSoft soft;
        //设置手机软件
        public void SetHandSetSoft(HandSetSoft soft)
        {
            this.soft = soft;
        }
        //运行
        public abstract void Run();
    }
}
