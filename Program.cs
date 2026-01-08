// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using ConsoleApp1;
using System;
using static ConsoleApp1.FindAndRemoveDuplicate;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        List<User> userkist = new List<User>();
        User user1 = new User(1, "a@gmail.com");
        User user2 = new User(2, "b@gmail.com");
        User user3 = new User(3, "a@gmail.com");

        userkist.Add(user1);
        userkist.Add(user2);
        userkist.Add(user3);


        // Console.WriteLine ("Try programiz.pro");
        var LSWithoutRC = new LengthofSubstringWithoutRepeatingcharater();
        Console.WriteLine(LSWithoutRC.LengthofSubstringWithoutRepeatingchar("abcabcbb"));
        Console.WriteLine('\n');


        var LSWitEqualAB = new LongestsubstringonEqualAandB();
        Console.WriteLine(LSWitEqualAB.LongestString("aababb"));
        Console.WriteLine('\n');

        var TargetInteger = new FindAndRemoveDuplicateIndicesOfTargetNumberOnAnyIntegerArray();
        Console.WriteLine(TargetInteger.IndicesOfTargetNumber([2, 7, 11, 15], 9));
        Console.WriteLine('\n');


        var Duplicate = new FindAndRemoveDuplicate();
        Console.WriteLine(Duplicate.FindDuplicateInteger([2, 7, 11, 15, 4, 7, 2, 15, 15]));
        Console.WriteLine(Duplicate.RemoveDuplicate(userkist));// { "Id":1,"email":"a@gmail.com"},{ "Id":2,"email":"a@gmail.com"},{ "Id":3,"email":"a@gmail.com"}));
        Console.WriteLine('\n');
        Console.WriteLine('\n');


        //var Rev = new Reverse();
        //Console.WriteLine(Rev.ReverseString("BUSHRA"));
        //Console.WriteLine(Rev.ReverseStringwithUserInput());
        //Console.WriteLine(Rev.ReverseStringUsingList());
        //Console.WriteLine(Rev.ReverseStringUsingStack());
        //Console.WriteLine(Rev.ReverseUsingQueue());
        //Console.WriteLine('\n');
        //Console.WriteLine('\n');



        var Dup = new FindDuplicateInAnArray();
        Console.WriteLine(Dup.FindDuplicatebyDictionary([1,2,2,3,4,5,6,6,6,7,8,9,9,9,9,9]));
        Console.WriteLine(Dup.FindDuplicateIntegerbyHashset([2, 7, 11, 15, 4, 7, 2, 15, 15]));
        Console.WriteLine(Dup.FindDuplicatebyLinQ());
        Console.WriteLine(Dup.FindDuplicatebySorting());
        Console.WriteLine('\n');


        var FindMiss = new FindMissingNumbercs();
        Console.WriteLine(FindMiss.FindMissingNumberbySumFormula([1, 2, 4, 5,]));
        Console.WriteLine(FindMiss.FindMissingNumberByXoR([1, 2, 3, 4, 5, 6, 7, 9]));
        Console.WriteLine(FindMiss.FindMissingNumberByHashset([1,2, 3, 4,6, 7]));
        Console.WriteLine(FindMiss.FindMissingNumberByHashset([1,3, 4, 5, 6, 7],8));
        Console.WriteLine(FindMiss.FindMissingNumberSort([1,2, 3, 5, 6, 7]));






    }




}