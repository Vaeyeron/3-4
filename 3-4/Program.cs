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
            
            int length = int.Parse(Console.ReadLine());
            One_Dim<int> oneDimIntArr = new One_Dim<int>(length, true);
            printer.Print<T>(oneDimIntArr);

            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            Multi_Dim<double> multiDimDoubleArr = new Multi_Dim<double>(rows, columns, true);
            printer.Print<T>(multiDimDoubleArr);
        }
    }
}
