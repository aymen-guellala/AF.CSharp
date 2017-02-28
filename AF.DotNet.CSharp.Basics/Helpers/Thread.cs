using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class ThreadHelper
    {
        public static void Run()
        {
            ThreadStart childref = new ThreadStart(CallToLauncherThread);
            Console.WriteLine("{0} - In Main: Creating the Launcher thread", Thread.CurrentThread.ManagedThreadId);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        public static void CallToLauncherThread()
        {
            Thread.Sleep(1000);


            Console.WriteLine("{0} - Starting a first thread with 2 sleep periods", Thread.CurrentThread.ManagedThreadId);
            Thread cThread1 = new Thread(() => CallToChildThread(2));
            cThread1.Start();

            Console.WriteLine("{0} - Starting a second thread with 5 sleep periods", Thread.CurrentThread.ManagedThreadId);
            Thread cThread2 = new Thread(() => CallToChildThread(5));
            cThread2.Start();

            Thread.Sleep(4000);
            Console.WriteLine("{0} - Aborting child threads", Thread.CurrentThread.ManagedThreadId);
            cThread1.Abort();
            cThread2.Abort();
        }

        public static void CallToChildThread(int sleep)
        {
            try
            {
                Console.WriteLine("{0} - Child thread starts", Thread.CurrentThread.ManagedThreadId);

                // do some work, like counting to 10
                for (int counter = 0; counter <= sleep; counter++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("{0} - {1}", Thread.CurrentThread.ManagedThreadId, counter);
                }

                Console.WriteLine("{0} - Child Thread Completed", Thread.CurrentThread.ManagedThreadId);
            }

            catch (ThreadAbortException e)
            {
                Console.WriteLine("{0} - Thread Abort Exception", Thread.CurrentThread.ManagedThreadId);
            }
            finally
            {
                Console.WriteLine("{0} - Thread finally block", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}
