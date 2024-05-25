using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVISION
{
    internal class SWAP
    {
        public static void swap<T>(ref T a ,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
