﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_3
{
    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
}
