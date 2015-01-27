using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP9
{
    class WorkExperience
    {
        
        private string _workDate;     
        private string _company;

        /// <summary>
        /// 公司
        /// </summary>
        public string WorkDate
        {
            get { return _workDate; }
            set { _workDate = value; }
        }
        /// <summary>
        /// 工作时间
        /// </summary>
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
    }
}
