using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP14_4
{
    interface ISubject
    {
        void Attach(Observer observer);
        void Detach(Observer observer);
        void Notify();
        string SecretaryAction{get;set;}
    }
}
