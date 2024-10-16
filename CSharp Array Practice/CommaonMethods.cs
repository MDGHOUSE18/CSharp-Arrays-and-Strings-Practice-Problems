using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class CommaonMethods
    {
        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
        }
    }
}
