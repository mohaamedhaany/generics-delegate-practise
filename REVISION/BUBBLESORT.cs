using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REVISION
{
    internal class BUBBLESORT<T> where T : IComparable
    {
        public static void bubblesort(T[] arr , Func<T,T,bool> fun) {
            bool flag = false;
            do {
                flag = false;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (fun(arr[j], arr[j+1]))
                    {
                        SWAP.swap(ref arr[j],ref arr[j+1]);
                        flag = true;
                    }
                }
            } while (flag);
        }
    }
}
