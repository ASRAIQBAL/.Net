using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class FindAndRemoveDuplicate
    {
        internal class User
        {
                public int Id {  get; set; }
            public string Email { get; set; }

            // Parameterized Constructor
            public User(int id, string email)
            {
                Id = id;
                Email = email;
                //Console.WriteLine($"A new user '{Id}' by {Email} has been created.");
            }

        }

        public List<int> FindDuplicateInteger(int[] nums)
        {
            var seen = new HashSet<int>();
            //var duplicates = new List<int>();
            var duplicates = new HashSet<int>(); // for unique integer output
            foreach(var n in nums)
            {
                if (!seen.Add(n))
                    duplicates.Add(n);             
            }
            Console.WriteLine("Duplicates Integer: " + string.Join(", ", duplicates.OrderBy(x => x).ToList()));

            return duplicates.OrderBy(x => x).ToList();

        }


        public List<User> RemoveDuplicate(List<User> Users)
        {
            var seenEmail = new HashSet<string>();
            var  result = new List<User>();

            foreach(var user in Users)
            {
                if (!seenEmail.Contains(user.Email))
                {
                    result.Add(user);
                    seenEmail.Add(user.Email);
                }
            }
            Console.WriteLine("Remove Duplicates Users: "+result );
            return result;


        }
    }
}
