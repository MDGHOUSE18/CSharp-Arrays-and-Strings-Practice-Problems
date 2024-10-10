using System;

namespace CSharp_Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 8, 4, 6, 7, 1, 3, 2, 9, 10,1,4,10,3,2,2,2,3,3,4,4,4 };

            int res = MissingNumber.MissingElement(arr,10);

            Console.WriteLine(res);
        }
    }
}
