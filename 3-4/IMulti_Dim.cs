using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    public interface IMulti_Dim<T>
    {
        void Initialize (int rows, int columns, bool user_Input);
        double Calculate_Average(Func<T, int> condition);
        void Reverse_Even_Rows(Action<T> action);
    }
}
