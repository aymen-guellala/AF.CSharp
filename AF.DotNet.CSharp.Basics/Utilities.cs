using System;
using System.Collections.Generic;
using System.Text;

namespace AF.DotNet.CSharp.Basics
{
    public class Utilities
    {
        public static void WriteTaskName(string taskName)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("\tTask:\t{0}", taskName);
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void WriteTaskName(int taskId, string taskName)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("\tTask[{0}]:\t{1}", taskId, taskName);
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void WriteLine()
        {
            Console.WriteLine("----------------------------------------------------------------");

        }

        public static void WriteDoubleLine()
        {
            Console.WriteLine("================================================================");

        }
    }
}
