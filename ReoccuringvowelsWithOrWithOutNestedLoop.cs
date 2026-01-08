using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class ReoccuringvowelsWithOrWithOutNestedLoop
    {
        public Dictionary<char, int> recurringVowelsWithoutLoop(string input)
        {
            Console.WriteLine("---------------recurringVowelsWithoutLoop complexity O(n)--------------------------------");
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            var result = new Dictionary<char, int>();
            foreach (char s in input.ToLower())
            {
                if (vowels.Contains(s))
                {
                    if (!result.ContainsKey(s))
                        result[s] = 0;
                    result[s]++;
                }
            }
            return result;
        }

        public Dictionary<char, int> recurringVowelsWithLoop(string input)
        {
            Console.WriteLine("---------------recurringVowelsWithLoop complexity O(n)--------------------------------");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            var result = new Dictionary<char, int>();
            foreach (var v in vowels)
            {
                int count = 0;
                foreach (char c in input.ToLower())
                {
                    if (c == v) count++;
                }
                if (count > 0)
                    result[v]=count;
            }
            return result;

        }
    }
}
