using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class AnonymousHelper
    {
        public delegate void Print(int value);

        public static void Run()
        {
            // Anonymous function
            Print print = delegate (int val)
            {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
            
            PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);



            // Anonymous Type
            var myAnonymousType = new
            {
                firstProperty = "First",
                secondProperty = 2,
                thirdProperty = true
            };

            IList<Person> PersonList = new List<Person>() {
                        new Person() { PersonID = 1, FirstName = "John", Age = 18 } ,
                        new Person() { PersonID = 2, FirstName = "Steve",  Age = 21 } ,
                        new Person() { PersonID = 3, FirstName = "Bill",  Age = 18 } ,
                        new Person() { PersonID = 4, FirstName = "Ram" , Age = 20  } ,
                        new Person() { PersonID = 5, FirstName = "Ron" , Age = 21 }
                    };

            // Linq Select returns anonymous type
            var PersonNames = from s in PersonList
                               select new
                               {
                                   PersonID = s.FirstName,
                                   PersonName = s.LastName
                               };
        }



        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }
    }
}
