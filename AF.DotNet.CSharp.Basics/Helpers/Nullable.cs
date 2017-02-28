using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class NullableHelper
    {
        public static void Run()
        {
            Nullable<int> a = null;

            if (a.HasValue)
                Console.WriteLine(a.Value); // or Console.WriteLine(i)
            else
                Console.WriteLine("Null");

            double? D = null;

            int? i = null;
            int j = 10;

            if (Nullable.Compare<int>(i, j) < 0)
                Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0)
                Console.WriteLine("i > j");
            else
                Console.WriteLine("i = j");

        }
    }
}
