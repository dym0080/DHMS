using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMSP22_4
{
    class Program
    {
        static void Main(string[] args)
        {
            HandSetBrand ab;
            ab = new HandSetBrandM();

            ab.SetHandSetSoft(new HandSetGame());
            ab.Run();

            ab.SetHandSetSoft(new HandSetAdressList());
            ab.Run();

            ab = new HandSetBrandN();
            ab.SetHandSetSoft(new HandSetGame());
            ab.Run();

            ab.SetHandSetSoft(new HandSetAdressList());
            ab.Run();

            Console.Read();

        }
    }
}
