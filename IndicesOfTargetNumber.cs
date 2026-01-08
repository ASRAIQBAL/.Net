using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class FindAndRemoveDuplicateIndicesOfTargetNumberOnAnyIntegerArray
    {
        public int[] IndicesOfTargetNumber(int[] num, int target)
        {

            var map = new Dictionary<int, int>();
            int[] indices = new int[num.Length];

            for (int i = 0; i < num.Length; i++)
            {
                int needed = target - num[i];
                if (map.ContainsKey(needed))
                {
                    //Console.WriteLine("Given Indexs contain value which will be added to target number");
                    indices = [map[needed], i];
                    //return indices;
                    //indices =new int { map[needed], i };
                    Console.WriteLine("Given Indexs contain value which will be added to target number");
                    Console.WriteLine(string.Join(", ", indices)); // FIXED PRINT
                    return indices;

                }
                map[num[i]] = i;
            }
            return Array.Empty<int>();

        }
    }
}