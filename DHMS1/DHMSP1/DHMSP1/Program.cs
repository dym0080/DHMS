using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation oper;
            oper = OperationFactory.createOperate("+");
            oper.NumberA = 9;
            oper.NumberB = 8;
            double result = oper.getResult();
            Console.WriteLine("结果是：" + result);

            //try
            //{
            //    Console.Write("请输入第一个数字：");
            //    string first = Console.ReadLine();
            //    Console.Write("请选择运算符号（+、-、*、/):");
            //    string operate = Console.ReadLine();
            //    Console.Write("请输入第二个数字：");
            //    string second = Console.ReadLine();
            //    string result = "";
            //    result = Convert.ToString(Operate.getResult(Convert.ToDouble(first), Convert.ToDouble(second), operate));
            //    //switch (operate)
            //    //{
            //    //    case "+":
            //    //        result = Convert.ToString(Convert.ToDouble(first) + Convert.ToDouble(second));
            //    //        break;
            //    //    case "-":
            //    //        result = Convert.ToString(Convert.ToDouble(first) - Convert.ToDouble(second));
            //    //        break;
            //    //    case "*":
            //    //        result = Convert.ToString(Convert.ToDouble(first) * Convert.ToDouble(second));
            //    //        break;
            //    //    case "/":
            //    //        if (second != "0")
            //    //            result = Convert.ToString(Convert.ToDouble(first) / Convert.ToDouble(second));
            //    //        else
            //    //            result = "除数不能为0";
            //    //        break;
            //    //}
            //    Console.WriteLine("结果是：" + result);
            //    Console.ReadLine();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("您输入的有误：" + ex.Message);
            //}
        }
    }
}
