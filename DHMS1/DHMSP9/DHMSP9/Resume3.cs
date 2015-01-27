using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP9
{
    /// <summary>
    ///简历类
    /// </summary>
    class Resume3:ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;

        private WorkExperience work;


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        public Resume3(string name)
        {
            this._name = name;
            work = new WorkExperience();
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

        public void SetWorkExperience(string timeArea, string company)
        {
            work.WorkDate = timeArea;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", _name, _sex, _age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }
    }
}
