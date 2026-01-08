using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class CountCharacterFequencyUingDictionary
    {
        public Dictionary<char, int> CountCharacterFrequency(string s)
        {
            Console.WriteLine("---------------CountCharacterFrequency complexity O(n)--------------------------------");
            Dictionary<char, int> CharacterFreq = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (CharacterFreq.ContainsKey(c))
                    CharacterFreq[c]++;
                else CharacterFreq[c] = 1;
            }
            return CharacterFreq;
        }
    }


}
