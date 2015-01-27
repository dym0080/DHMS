using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMS13
{
    class PersonDirector
    {
        private PersonBuilder pb;
        public PersonDirector(PersonBuilder pb)
        {
            this.pb = pb;
        }

        public void CreatePerson()
        {
            pb.BuildBody();
            pb.BuildHead();
            pb.BuildArmLeft();
            pb.BuildArmRight();
            pb.BuildLegLeft();
            pb.BuildLegRight();
        }
    }
}
