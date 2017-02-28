using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class ActionHelper
    {
        public static void Run()
        {
            Action<int> printActionDel_1 = ConsolePrint;
            Action<int> printActionDel_2 = new Action<int>(ConsolePrint);

            // Anonymous method with Action delegate
            Action<int> printActionDel_3 = delegate (int i)
            {
                Console.WriteLine("Console Write from Anonymous method with Action delegate: {0}", i);
            };

            printActionDel_3(10);
            
            //  Lambda expression with Action delegate
            Action<int> printActionDel_4 = i => Console.WriteLine("Console Write from Lambda expression with Action delegate: {0}", i);
            printActionDel_4(10);
        }

        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
    }
}
