using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP6
{
    abstract class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component com)
        {
            this.component = com;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
