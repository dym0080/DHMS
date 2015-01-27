using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP8
{
    /// <summary>
    /// 运算类
    /// </summary>
    class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumeberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
