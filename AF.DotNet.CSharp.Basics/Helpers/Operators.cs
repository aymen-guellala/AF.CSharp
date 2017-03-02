using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    public class OperatorsHelper
    {
        public static void Run()
        {
            Person p = new Person("Alice", "Moureau");
            if (p is Student)
                Console.WriteLine("It's a student");
            else
                Console.WriteLine("It's not a student");

            int? x = null;

            // Set y to the value of x if x is NOT null; otherwise,
            // if x = null, set y to -1.
            int y = x ?? -1;

            // Ternary operator
            int z = x == null ? 5 : 10;

            StringDataStore store = new StringDataStore();

            int? length = p?.Age; // null if customers is null   
            string str = store?[0];  // null if customers is null  
            // int? count = customers?[0]?.Orders?.Count();  // null if customers, the first customer, or Orders is null 

            switch (z)
            {
                case 5:
                    Console.WriteLine("Value of variable is 5");
                    break;
                case 10:
                    Console.WriteLine("Value of variable is 10");
                    break;
                default:
                    Console.WriteLine("Unknown value");
                    break;
            }
        }
    }
}
