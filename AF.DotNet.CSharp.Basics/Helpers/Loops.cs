using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class LoopsHelper
    {
        public static void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.WriteLine("Value of i: {0}", i);
            }

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine("Value of k: {0}", k);
                k++;
            }

            int j = 0;
            do
            {
                Console.WriteLine("Value of j: {0}", j);
                j++;

            } while (j < 10);
        }
    }
}
