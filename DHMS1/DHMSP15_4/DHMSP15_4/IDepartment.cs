﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_4
{
    interface IDepartment
    {

        void Insert(Department department);
        Department GetDepartment(int id);
    }
}
