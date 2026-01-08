using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class FindMissingNumbercs
    {
        public int FindMissingNumberbySumFormula(int[]arr)
        {
            Console.WriteLine("---------------FindMissingNumberbySumFormula 1st Priority complexity O(n)--------------------------------");
            int num = arr.Length + 1;
            int ExpectedSum = num * (num + 1) / 2;
            int actualSum = 0;

            foreach(int n in arr)
            {
                actualSum += n;
            }
            return ExpectedSum - actualSum;

    }

        public int FindMissingNumberByXoR(int[]arr) {
       Console.WriteLine("---------------FindMissingNumberbyXOR 1st Priority noRiskFlow complexity O(n)--------------------------------");
            int n = arr.Length + 1;
            int xorAll = 0;
            for(int i=1; i<=n; i++)
            {
                xorAll ^= i;
            }
            foreach(int num in arr)
                xorAll ^= num;
            return xorAll;
        }


        public int FindMissingNumberByHashset(int[] arr)
        {
            Console.WriteLine("---------------FindMissingNumberByHashset 2nd Priority  complexity O(n)--------------------------------");
            HashSet<int> set = new HashSet<int>(arr);
            int n = arr.Length + 1;
            for (int i = 1; i <= n; i++)
            {
                if (!set.Contains(i))
                    return i;
            }
            return -1;
        }

        public int FindMissingNumberByHashset(int[] arr, int n)
        {
            Console.WriteLine("---------------FindMissingNumberByHashset 2nd Priority  complexity O(n)--------------------------------");
            HashSet<int> set = new HashSet<int>(arr);

            for (int i = 1; i <= n; i++)
            {
                if (!set.Contains(i))
                    return i;
            }
            return -1;
        }
        public int FindMissingNumberSort(int[] arr)
        {
            Console.WriteLine("---------------FindMissingNumberSort 3rd Priority  complexity O(n Log n)--------------------------------");
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                    return i + 1;
            }
            return arr.Length + 1;
        }


    }
}
