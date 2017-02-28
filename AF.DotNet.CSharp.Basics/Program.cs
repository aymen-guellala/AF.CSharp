using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics
{

    class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();
        }

        [Obsolete("Don't use Dump, use PrintMenu instead", true)]
        public static void Dump()
        {
        }

        public static void PrintMenu()
        {
            string currentNameSpace = Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace;

            Type[] helpers = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => String.Equals(t.Namespace, currentNameSpace+".Helpers", StringComparison.Ordinal)
                        && t.Name.ToLower().EndsWith("helper") && t.IsClass && !t.FullName.Contains("+"))
                .OrderBy(t => t.Name).ToArray();

            Console.Clear();
            Utilities.WriteDoubleLine();
            Console.WriteLine("\tPlease choose a task ID");
            Utilities.WriteDoubleLine();

            for (var i = 0; i < helpers.Length; i++)
            {
                Console.WriteLine("\t\t{0:00} - {1}", i + 1, helpers[i].Name.Replace("Helper", ""));
            }

            Utilities.WriteLine();
            if (helpers.Length > 0)
            {
                int choice = 0;
                do
                {
                    choice = 0;
                    Console.Write("\tEnter Value : ");
                    var ans = Console.ReadLine();
                    int.TryParse(ans, out choice);

                } while (choice > helpers.Length || choice < 1);

                Console.Clear();

                Utilities.WriteTaskName(choice, helpers[choice - 1].Name.Replace("Helper", ""));
                helpers[choice - 1].GetMethod("Run").Invoke(null, null);

                //GC.Collect();

                Utilities.WriteDoubleLine();
                GC.Collect();
                Console.WriteLine("Press any key to return to menu...");
                Console.ReadKey();
                PrintMenu();
            }
        }

    }
}
