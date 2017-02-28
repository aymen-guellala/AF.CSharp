using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class FuncHelper
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void Run()
        {
            Func<int, int, int> add = Sum;
            Console.WriteLine(add(10, 10));

            // Func with zero input parameter, with an Anonymous method
            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
            Console.WriteLine("this is a random integer : {0}", getRandomNumber());

            // Function with lambda expression
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Func<int, int, int> Sum2 = (x, y) => x + y;
        }
    }
}
