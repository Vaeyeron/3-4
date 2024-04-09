using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    public interface IOne_Dim<T>
    {
        void Initialize(int length, bool user_Input = false);
        double Calculate_Average(Func<T, int> condition);
        void Remove_Elements_More_Than_Abs_100(Action<T> action);
        void Remove_Duplicate_Elements(Action<T> action);
    }
}
