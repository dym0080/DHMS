﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP20_3
{
    class ConcreteAggregate:Aggregate
    {
        //声明一个IList泛型变量，用于存放聚合对象，用ArrayList同样可以实现
        private IList<object> items=new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        } 
        //返回聚集总个数
        public int Count
        {
            get { return items.Count; }
        }
        //声明一个索引器
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
        
    }
}
