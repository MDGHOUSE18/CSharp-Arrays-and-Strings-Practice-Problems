using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    //How do remove duplicates from a given array?
    internal class RemoveDuplicates
    {
        public static void UniqueArray()
        {
            int[] arr = {10,54,1,4,24,10,30,45,54};
            Console.WriteLine("Original Array");

            CommaonMethods.PrintArray(arr);

            Console.WriteLine("Modified Array");

            //UsingHashSet(arr);
            UniqueElements(arr);

        }

        //using HashSet 
        public static void UsingHashSet(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (int num in arr)
            {
                set.Add(num);
            }
            foreach (int num in set)
            {
                Console.Write(num + " ");
            }

        }

        //Without Collection
        public static void UniqueElements(int[] arr)
        {
            Array.Sort(arr);
            for(int i=0;i<arr.Length-1;i++)
            {
                if(arr[i] == arr[i+1])
                {
                    arr[i] = 0;
                }
            }
            foreach (int num in arr)
            {
                if (num==0)
                {
                    continue;
                }
                Console.Write(num + " ");
            }

        }

        //ChatGpt
        public static void UniqueElementsByC(int[] arr)
        {
            Array.Sort(arr); // Sorting helps to compare adjacent elements easily
            List<int> uniqueElements = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                // Check if it's the first occurrence or different from the previous element
                if (i == 0 || arr[i] != arr[i - 1])
                {
                    uniqueElements.Add(arr[i]); // Add unique element to the list
                }
            }

            // Print the unique elements
            foreach (int num in uniqueElements)
            {
                Console.Write(num + " ");
            }
        }


    }
}
