using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP15_4
{
    interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}
