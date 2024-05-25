using System.Security.Cryptography.X509Certificates;

namespace REVISION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5,3,1,4,2 };
            BUBBLESORT<int>.bubblesort(arr,bubblesorttyps<int>.acending); 
            foreach (int i in arr) { 
            Console.WriteLine(i);   
            }
        }
    }
}
