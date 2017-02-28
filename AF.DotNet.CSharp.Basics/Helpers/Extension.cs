using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    static class ExtensionHelper
    {
        public static void Run()
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine(result);
        }

        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
