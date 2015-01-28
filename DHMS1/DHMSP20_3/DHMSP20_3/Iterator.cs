using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP20_3
{
    //迭代器抽象类
    abstract class Iterator
    {
        //用于定义得到开始对象、下一个对象、判读是否到结尾、当前对象等抽象方法，统一接口
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }
}
