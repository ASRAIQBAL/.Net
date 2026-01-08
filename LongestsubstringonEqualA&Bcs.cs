// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class LongestsubstringonEqualAandB
{

    public int LongestString(string s)
    {
        int l = s.Length;
        int Longest = 0;
        string str = "";
        //var result = new Dictionary<string,int>();
        for (int i = 0; i < l; i++)
        {
            int counterA = 0; int counterB = 0;
            for (int j = i; j < l; j++)
            {
                if (s[j] == 'a' || s[j] == 'A')
                {
                    counterA++;
                    //str = string.Concat(s[j]);
                }
                else
                {
                    counterB++;
                    //str = string.Concat(s[j]);
                }

                if (counterA == counterB)
                {
                    Longest = Math.Max(Longest, j - i + 1);
                    //str = s.Substring(i);
                    //Console.Write(str);

                    //result.Add(str, Longest);

                    // result = s[j];

                }

            }

        }
        Console.WriteLine("Length of Longest Substring With equal numbers of A and B charater:");
        return Longest;

    }


}