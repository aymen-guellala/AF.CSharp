using System;
using System.Collections.Generic;
using System.Text;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    public enum WeekDays
    {
        Monday = 0,
        Tuesday = 1,
        Wednesday = 2,
        Thursday = 3,
        Friday = 4,
        Saturday = 5,
        Sunday = 6
    }

    class EnumHelper
    {
        public static void Run()
        {
            Console.WriteLine("Friday:");
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Friday);
            
            Console.WriteLine("Third day of week is: {0}", Enum.GetName(typeof(WeekDays), 2));

            Console.WriteLine("WeekDays constant names:");

            foreach (string str in Enum.GetNames(typeof(WeekDays)))
                Console.WriteLine(str);

            Console.WriteLine("Enum.TryParse():");

            WeekDays wdEnum;
            Enum.TryParse<WeekDays>("1", out wdEnum);
            Console.WriteLine(wdEnum);
        }
    }
}
