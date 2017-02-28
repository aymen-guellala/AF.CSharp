using System;
using System.Collections.Generic;
using System.Text;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class InterfaceHelper
    {
        public static void Run()
        {
            ILog dLog = new DateLog();
            dLog.Log("Msg from DateLog");

            ILog tLog = new TimeLog();
            tLog.Log("Msg from TimeLog");

            ILog dtLog = new DateTimeLog();
            dtLog.Log("Msg from DateTimeLog");
        }
    }

    interface ILog
    {
        void Log(string msgToLog);
    }

    // Implicit Implementation
    class DateLog : ILog
    {
        public void Log(string msgToPrint)
        {
            Console.WriteLine("[{0}] {1}", DateTime.Now.Date.ToString(), msgToPrint);
        }
    }
    // Implicit Implementation
    class TimeLog : ILog
    {
        public void Log(string msgToPrint)
        {
            Console.WriteLine("[{0}] {1}", DateTime.Now.TimeOfDay.ToString(), msgToPrint);
        }
    }

    // Explicit Implementation
    class DateTimeLog : ILog
    {
        void ILog.Log(string msgToPrint) // explicit implementation
        {
            Console.WriteLine("[{0}] {1}", DateTime.Now.ToString(), msgToPrint);
        }
    }

}
