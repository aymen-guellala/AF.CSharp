using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class ArrayHelper
    {
        public static void Run()
        {
            int[] intArray;  // can store int values
            string[] stringArray; // can store string values
            Person[] personClassArray; // can store instances of person class


            // defining array with size 5. add values later on
            int[] intArray1 = new int[5];

            // defining array with size 5 and adding values at the same time
            int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

            // defining array with 5 elements which indicates the size of an array
            int[] intArray3 = { 1, 2, 3, 4, 5 };

            // int[] intArray = new int[]; // compiler error: must give size of an array


            // Multidimentional array
            int[,] intBidimentionalArray = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            // Jagged array
            int[][] intJaggedArray = new int[2][];
            intJaggedArray[0] = new int[3] { 1, 2, 3 };
            intJaggedArray[1] = new int[2] { 4, 5 };

            bool[] boolArray = Enumerable.Repeat(true, 13).ToArray(); // creates bool array of size 13 with default value “true”
            int[] integerArray = Enumerable.Repeat(12, 35).ToArray(); // creates int array of size 35 with default value “12”
            string[] strArray = Enumerable.Repeat("Welcome", 6).ToArray();// creates string array of size 6 with default value “Welcome”

        }
    }
}
