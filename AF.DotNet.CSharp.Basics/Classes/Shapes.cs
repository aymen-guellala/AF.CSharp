using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Classes
{
    public class Shape
    {
        protected int width, height;
        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int GetArea()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }

        public static bool operator ==(Shape b, Shape c)
        {
            return b.GetArea() == c.GetArea();
        }
        public static bool operator !=(Shape b, Shape c)
        {
            return b.GetArea() != c.GetArea();
        }
    }
    public class Rectangle : Shape
    {
        public int Coast { get; set; }

        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public Rectangle(int a = 0, int b = 0, int c = 0) : base(a, b)
        {
            Coast = c;
        }
        public override int GetArea()
        {
            //Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
        public int GetCoast()
        {
            return GetArea() * Coast;
        }
    }
    public class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int GetArea()
        {
            //Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }
}
