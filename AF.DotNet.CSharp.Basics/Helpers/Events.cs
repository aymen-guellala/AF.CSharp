using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class EventHelper
    {
        public static void Run()
        {
            Number myNumber = new Number(100000);
            myNumber.PrintMoney();
            myNumber.PrintNumber();
        }


        public class PrintHelper
        {
            // declare delegate 
            public delegate void BeforePrint(string message);

            //declare event of type delegate
            public event BeforePrint beforePrintEvent;

            public PrintHelper()
            {

            }

            public void PrintNumber(int num)
            {
                //call delegate method before going to print
                if (beforePrintEvent != null)
                    beforePrintEvent.Invoke("PrintNumber");

                Console.WriteLine("Number: {0,-12:N0}", num);
            }

            public void PrintDecimal(int dec)
            {
                if (beforePrintEvent != null)
                    beforePrintEvent("Printecimal");

                Console.WriteLine("Decimal: {0:G}", dec);
            }

            public void PrintMoney(int money)
            {
                if (beforePrintEvent != null)
                    beforePrintEvent("PrintMoney");

                Console.WriteLine("Money: {0:C}", money);
            }            
        }

        class Number
        {
            private PrintHelper _printHelper;

            private int _value;
            public Number(int val)
            {
                _value = val;

                _printHelper = new PrintHelper();
                
                //subscribe to beforePrintEvent event
                _printHelper.beforePrintEvent += printHelper_beforePrintEvent;
            }

            //beforePrintevent handler
            void printHelper_beforePrintEvent(string message)
            {
                Console.WriteLine("BeforPrintEventHandler <{0}>: PrintHelper is going to print a value",message);
            }
                        
            public void PrintMoney()
            {
                _printHelper.PrintMoney(_value);
            }

            public void PrintNumber()
            {
                _printHelper.PrintNumber(_value);
            }
        }
    }
}
