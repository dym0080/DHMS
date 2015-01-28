﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP19_5
{
    //公司类（可以为抽象类或接口）
    abstract class Company
    {
        protected string name;
        public Company(string name)
        { this.name = name; }

        public abstract void Add(Company c);//增加
        public abstract void Remove(Company c);//移除
        public abstract void Display(int depth);//显示
        public abstract void LineOfDuty();//履行职责
    }
}
