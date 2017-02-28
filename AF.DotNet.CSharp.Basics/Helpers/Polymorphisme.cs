using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class PolymorphismHelper
    {
        public static void Run()
        {
            Console.WriteLine(" - Static polymorphism : Overloading - CompileTime :");

            Printdata p = new Printdata();

            // Call print to print integer
            p.print(5);
            // Call print to print float
            p.print(500.263);
            // Call print to print string
            p.print("Hello C++");

            Console.WriteLine(" - Dynamic polymorphism : overriding - RunTime :");

            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            CallArea(r);
            CallArea(t);
        }

        public static void CallArea(Shape sh)
        {
            int a;
            a = sh.GetArea();
            Console.WriteLine("Area : {0}", a);
        }
    }

    public class Printdata
    {
        public void print(int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        public void print(double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        public void print(string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }
    }


}
