using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class GenericHelper
    {
        public delegate T add<T>(T param1, T param2);
       
        public static void Run()
        {
            // Generic class <int>
            MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
            int val = intGenericClass.genericMethod(200);

            // Generic class <string>
            MyGenericClass<string> strGenericClass = new MyGenericClass<string>("Hello Generic World");
            strGenericClass.genericProperty = "This is a generic property example.";
            string result = strGenericClass.genericMethod("Generic Parameter");

            // Generics in delegates
            add<int> sum = AddNumber;
            Console.WriteLine(sum(10, 20));
            add<string> conct = Concate;
            Console.WriteLine(conct("Hello", "World!!"));
        }

        public static int AddNumber(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concate(string str1, string str2)
        {
            return str1 + str2;
        }
    }

    class MyGenericClass<T>
    {
        private T genericMemberVariable;

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        public T genericProperty { get; set; }
    }

}
