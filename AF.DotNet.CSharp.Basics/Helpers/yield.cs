using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class yieldHelper
    {
        public static void Run()
        {
            Variety variety = new Variety();
            foreach (string color in variety.UVtoIR())
                Console.Write("{0} ", color);
            Console.WriteLine();
            foreach (string color in variety.IRtoUV())
                Console.Write("{0} ", color);
            Console.WriteLine();
        }

        public IEnumerator<string> Colors_v1() // Version 1
        {
            yield return "black"; // yield return
            yield return "red"; // yield return
            yield return "white"; // yield return
        }

        public IEnumerator<string> Colors_v2() // Version 2
        {
            string[] theColors = { "black", "red", "white" };
            for (int i = 0; i < theColors.Length; i++)
                yield return theColors[i]; // yield return
        }
    }

    class Variety
    {
        string[] colors = { "violet", "blue", "cyan", "green", "yellow", "orange", "red" };
        //Returns an enumerable
        public IEnumerable<string> UVtoIR()
        {
            for (int i = 0; i < colors.Length; i++)
                yield return colors[i];
        }
        //Returns an enumerable
        public IEnumerable<string> IRtoUV()
        {
            for (int i = colors.Length - 1; i >= 0; i--)
                yield return colors[i];
        }
    }
}
