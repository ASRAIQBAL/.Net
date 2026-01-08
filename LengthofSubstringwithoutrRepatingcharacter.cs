using System;

public class LengthofSubstringWithoutRepeatingcharater
{
	public int LengthofSubstringWithoutRepeatingchar(string s)
	{
		var length = s.Length;
		int maxlength = 0; int start = 0;
		var Dictionary = new Dictionary<char,int>();

		for(int i = 0;  i < length; i++)
		{
			if(Dictionary.ContainsKey(s[i]) && Dictionary[s[i]] >= start)
			{
				start = Dictionary[s[i]] + 1;
			}
			Dictionary[s[i]] = i;
			maxlength = Math.Max(maxlength, i-start+1);
		}
		Console.WriteLine("Length of Longest Substring Without Repeating charater:");  return maxlength;
	}
}
