using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Reverse
    {
        public string ReverseString(string s)
        {
            Console.WriteLine("---------------ReverseStringwithLoop--------------------------------");
            char[] charArray = s.ToCharArray();
            string result = "";
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                result += charArray[i];

            }
            Console.WriteLine("reverse of givin string", result);
            return result;
        }

        public string ReverseStringwithUserInput()
        {
            Console.WriteLine("---------------ReverseStringwithUserInput--------------------------------");
            Console.WriteLine("Enter any string:");
            string s = Console.ReadLine();
            char[] charArray = s.ToCharArray();
            string result = "";
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                result += charArray[i];

            }
            Console.WriteLine("reverse of givin string", result);
            return result;
        }

        public string ReverseStringUsingStack()
        {
            Console.WriteLine("---------------ReverseStringwithUseInputStack  best conceptual fit--------------------------------");
            Console.WriteLine("---------------O(n) complexity meansO(n) time complexity, or linear time, means that the time an algorithm takes to run is directly proportional to the size of its input (denoted as n). --------------------------------");

            Console.WriteLine("Enter any string:");
            string s = Console.ReadLine();

            Stack<char> stack = new Stack<char> ();
            foreach(char c in s)
            {
                stack.Push(c);
            }
            char[] result = new char[s.Length];
            int i = 0;
            while (stack.Count > 0)
            result[i++] = stack.Pop();

            Console.WriteLine("reverse of givin string  stack", result);
            return new string(result);
        }

        public string ReverseStringUsingList()
        {
            Console.WriteLine("-----------------ReverseStringwithUserInput&List 2nd prority--------------------------------");
            Console.WriteLine("---------------O(n) complexity meansO(n) time complexity, or linear time, means that the time an algorithm takes to run is directly proportional to the size of its input (denoted as n). --------------------------------");

            Console.WriteLine("Enter any string:");
            string s = Console.ReadLine();

            List<char> result = new List<char>(s);
            result.Reverse();
            Console.WriteLine("reverse of givin string by List", result.ToArray());
            return new string(result.ToArray());

        }

        public string ReverseUsingQueue()
        {
            Console.WriteLine("-------------------------ReverseStringwithUserInput&QUEUE  3rd prority-------------------------------------------");
            Console.WriteLine("---------------O(n) complexity meansO(n) time complexity, or linear time, means that the time an algorithm takes to run is directly proportional to the size of its input (denoted as n). --------------------------------");

            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Queue<char> queue = new Queue<char>();

            for (int i = input.Length - 1; i >= 0; i--)
                queue.Enqueue(input[i]);

            return new string(queue.ToArray());
        }

    }
}
