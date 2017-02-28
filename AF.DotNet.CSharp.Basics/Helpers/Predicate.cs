using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class PredicateHelper
    {
        public static void Run()
        {
            Predicate<string> isUpper = IsUpperCase;
            bool result = isUpper("hello world!!");
            Console.WriteLine(result);

            // Predicate delegate with anonymous method

            Predicate<string> isUpper_1 = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result_1 = isUpper_1("hello world!!");

            // Predicate delegate with lambda expression
            Predicate<string> isUpper_2 = s => s.Equals(s.ToUpper());
            bool result_2 = isUpper_2("hello world!!");

        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

    }
}
