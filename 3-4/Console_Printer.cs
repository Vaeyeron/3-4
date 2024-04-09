using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    public class Console_Printer : IPrinter
    {
        public void Print<T>(T[] _array)
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
