using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    internal class FindDuplicateInAnArray
    {
        public string FindDuplicatebyDictionary(int[] arry)
        //public List<int>FindDuplicatebyDictionary(int[] arry)  --> return res.OrderBy(x => x).ToList();

        {
            Console.WriteLine("---------------FindDuplicatebyDictionary 1st Priority complexity O(n)--------------------------------");
            Console.WriteLine("", string.Join(",", arry.ToList()));
            Dictionary<int, int> dup = new Dictionary<int, int>();
            List<int> res = new List<int>();
            foreach (int i in arry)
            {
                if (dup.ContainsKey(i))
                {
                    dup[i]++;

                }
                else
                {
                    dup[i] = 1;
                }
            }

            foreach (var item in dup)
            {
                if (item.Value > 1) res.Add(item.Key);
            }

            //return res.ToList();
            //return res.OrderBy(x => x).ToList();
            return string.Join(", ", res.OrderBy(x => x));

        }
        public List<int> FindDuplicateIntegerbyHashset(int[] nums)
        {
            Console.WriteLine("---------------FindDuplicateIntegerbyHashset 2nd Priority complexity O(n)--------------------------------");
            var seen = new HashSet<int>();
            var duplicates = new HashSet<int>(); // for unique integer output
            foreach (var n in nums)
            {
                if (!seen.Add(n))
                    duplicates.Add(n);
            }
            Console.WriteLine("Duplicates Integer: " + string.Join(", ", duplicates.OrderBy(x => x).ToList()));

            return duplicates.OrderBy(x => x).ToList();

        }
        public string FindDuplicatebyLinQ()
        //public List<int> FindDuplicatebyLinQ()  --> when return duplicates.ToList();
        {
            Console.WriteLine("---------------FindDuplicatebyLINQ 3rd Priority complexity O(n)--------------------------------");

            int[] arr = { 1, 2, 3, 4, 2, 3, 5 };
            //Console.WriteLine("Array to find Duplicates", string.Join(", ", arr.ToList()));

            var duplicates = arr.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
            //Console.WriteLine(string.Join(", ", duplicates));extra code
            //foreach (var d in duplicates)
            //{
            //    Console.WriteLine(d);
            //}
            //return duplicates.ToList();
            return string.Join(", ", duplicates.OrderBy(x => x).ToList());
        }

        public List<int> FindDuplicatebySorting() {
            Console.WriteLine("---------------FindDuplicatebySorting 4th Priority  complexity O(n log n)--------------------------------");
            List<int> res = new List<int>();
            int[] arr = { 1, 1, 3, 4, 2, 3, 5 ,4};

        Array.Sort(arr);

for (int i = 0; i<arr.Length - 1; i++)
{
                if (arr[i] == arr[i + 1])
                    res.Add(arr[i]);
        //Console.WriteLine($"Duplicate: {arr[i]}"); this is also correct
}
            Console.WriteLine("Duplicates Integer: " + string.Join(", ", res.OrderBy(x => x).ToList()));
            return res;

}



    }

}
