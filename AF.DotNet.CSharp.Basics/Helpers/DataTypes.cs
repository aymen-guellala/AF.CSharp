using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class DataTypesHelper
    {
        public static void Run()
        {
            int i1 = 3, i2 = 5;    /* initializing i1 and i2. */
            byte z = 22;         /* initializes z. */
            double pi = 3.14159; /* declares an approximation of pi. */
            char x = 'x';        /* the variable x has the value 'x'. */
            int k, l = 0;

            int @int = (int)1 / 3;
            // @int = 0
            Console.WriteLine("[int]1/3 = {0}", @int);

            float @float = (float)1 / 3;
            // @float = 0.333333343
            Console.WriteLine("[float]1/3 = {0}", @float);

            double @double = (double)1 / 3;
            // @double = 0.33333333333333331
            Console.WriteLine("[double]1/3 = {0}", @double);

            decimal @decimal = (decimal)1 / 3;
            // @decimal = 0.3333333333333333333333333333
            Console.WriteLine("[decimal]1/3 = {0}", @decimal);


            int a = 75;
            float f = 53.005f;
            double d = 2345.7652d;
            bool b = true;

            int i = 1;
            Console.WriteLine("[Value Type] value before change: {0}", i);
            ChangeValueType(i);
            Console.WriteLine("[Value Type] value after change: {0}", i);

            string s = "Old value";
            Console.WriteLine("[Value Type] value before change: {0}", s);
            ChangeValueType(s);
            Console.WriteLine("[Value Type] value after change: {0}", s);

            Person person = new Person("Daniel", "Patata");
            Console.WriteLine("[Reference Type] value before change: {0}", person.FirstName);
            ChangeReferenceType(person);
            Console.WriteLine("[Reference Type] value after change: {0}", person.FirstName);
        }

        public static void ChangeValueType(int i)
        {
            i = 222;
        }

        public static void ChangeValueType(string s)
        {
            s = "New Value";
        }

        public static void ChangeReferenceType(Person p)
        {
            p.FirstName = "Alex";
        }
    }
}
