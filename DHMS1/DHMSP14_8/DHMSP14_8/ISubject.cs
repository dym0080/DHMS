using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_8
{
    interface ISubject
    {
        void Notify();
        string SecretaryAction { get; set; }
    }
}
