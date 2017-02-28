using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    public class DelegateHelper
    {
        // declare delegate
        public delegate void Print(int value);

        public static void Run()
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            printDel(100000);
            printDel.Invoke(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel.Invoke(200);

            Console.WriteLine("----------");

            // Multicast delegate
            printDel = PrintNumber;
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(100000);

            Console.WriteLine("----------");

            // Delegate Parameter
            PrintHelper(PrintNumber, 10000);
            PrintHelper(PrintMoney, 10000);
        }
        
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }
    }
}
