using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Array_Practice
{
    internal class MissingNumber
    {
        //My approach
        //Time Complexity: O(Nlog(N)) & Space Complexity: O(1) (or O(log(N)) depending on sorting algorithm).
        public static int MissingElement(int[] arr, int N)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i]+1 != arr[i + 1] && arr[i] != arr[i+1])
                {
                    return arr[i]+1;
                }
            }
            return -1;
        }

        //Improved version
        //Time Complexity: O(N) & Space Complexity: O(1)
        public static int Missing_Element(int[] arr, int N)
        {
            if (arr == null || arr.Length == 0) return -1;

            // Use the sum formula: sum of first N natural numbers
            int expectedSum = (N * (N + 1)) / 2;
            int actualSum = 0;

            // Sum all elements in the array
            foreach (int num in arr)
            {
                actualSum += num;
            }

            // The difference will be the missing element
            return expectedSum - actualSum;
        }

        //Handling Duplicates with HashSet:
        //Time Complexity: O(N) & Space Complexity: O(N)
        public static int MissingElementInDuplicates(int[] arr, int N)
        {
            HashSet<int> uniqueNumbers = new HashSet<int>();
            int expectedSum = (N * (N + 1)) / 2;
            int actualSum = 0;

            foreach (int num in arr)
            {
                if (uniqueNumbers.Add(num))
                {
                    actualSum += num;
                }
            }

            return expectedSum - actualSum;
        }


    }
}
