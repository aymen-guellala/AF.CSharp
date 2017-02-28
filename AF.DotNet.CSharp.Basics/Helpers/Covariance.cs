using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    public delegate Small covarDel(Big mc);

    class CovarianceHelper
    {
        public static void Run()
        {
            covarDel del1 = Method1;
            Small sm = del1(new Big());

        }

        static Big Method1(Big bg)
        {
            Console.WriteLine("Method1");

            return new Big();
        }
        static Small Method2(Big bg)
        {
            Console.WriteLine("Method2");

            return new Small();
        }

    }

    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }

}
