using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Classes
{
    class Line
    {
        // Property : Length of a line
        private double length;

        // constructor
        public Line()
        {
            Console.WriteLine("Object is being created");
        }
        ~Line() //destructor
        {
            //Console.WriteLine("Object is being deleted");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }
    }
}
