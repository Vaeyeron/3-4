using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new Console_Printer();

            One_Dim<int> oneDimIntArr = new One_Dim<int>(5, true);
            printer.Print(oneDimIntArr);

            Multi_Dim<double> multiDimDoubleArr = new Multi_Dim<double>(3, 3, true);
            printer.Print(multiDimDoubleArr);
        }
    }
}
