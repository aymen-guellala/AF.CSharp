using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class ExceptionHelper
    {
        public static void Run()
        {
            int zero = 0;

            try
            {
                int result = 5 / zero;  // this will throw an exception       

            }
            catch (Exception ex) when (ex is DivideByZeroException || ex is InvalidCastException)
            {
                Console.WriteLine("Inside catch block. Exception: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Inside finally block.");

            }


            try
            {
                Person person = null;
                if (person == null)
                    throw new NullReferenceException("Person object is null.");

                Console.WriteLine(person.FirstName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try
            {
                Person person = new Person("0Alex", "Dupont");
                if (person.FirstName.StartsWith("0"))
                    throw new InvalidNameException(person.FirstName);

                Console.WriteLine(person.FirstName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("Cannot divide by zero. Please try again.");
            }
            catch (InvalidOperationException ex)
            {
                Console.Write("Not a valid number. Please try again.");
            }
            catch (FormatException ex)
            {
                Console.Write("Not a valid number. Please try again.");
            }
        }
    }

    [Serializable]
    class InvalidNameException : Exception
    {
        public InvalidNameException()
        {

        }

        public InvalidNameException(string name)
        : base(String.Format("Invalid person Name: {0}", name))
        {

        }
    }
}
