using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP9
{
    /// <summary>
    ///简历类2
    /// </summary>
    class Resume2:ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private string _timeArea;
        private string _company;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        public Resume2(string name)
        {
            this._name = name;
        }
        /// <summary>
        /// 设置性别和年龄
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string timeArea,string company)
        {
            this._timeArea = timeArea;
            this._company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _sex, _age);
            Console.WriteLine("工作经历：{0} {1}", _timeArea, _company);
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
