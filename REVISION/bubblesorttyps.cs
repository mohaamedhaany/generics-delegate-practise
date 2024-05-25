using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVISION
{
    internal class bubblesorttyps<T> where T : IComparable
    {
        public static bool acending(T a , T b)
        {
            return a.CompareTo(b) == 1;  
        }
        public static bool decending(T a, T b)
        {
            return a.CompareTo(b) == -1;
        }
    }
}
