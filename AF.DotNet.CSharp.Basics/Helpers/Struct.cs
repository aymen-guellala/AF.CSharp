using System;
using System.Collections.Generic;
using System.Text;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class StructHelper
    {
        public static void Run()
        {
            Point.StaticMethod();

            Point p = new Point();

            p.PointChanged += StructEventHandler;
            p.XPoint = 123;

            p.PrintPoints();
        }

        public static void StructEventHandler(int point)
        {
            Console.WriteLine("Point changed to {0}", point);
        }
    }

    struct Point
    {
        private int _x, _y;

        public int x, y;

        public static int X, Y;

        public int XPoint
        {
            get
            {
                return _x;
            }

            set
            {
                _x = value;
                PointChanged(_x);
            }
        }

        public int YPoint
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
                PointChanged(_y);
            }
        }

        public event Action<int> PointChanged;

        public void PrintPoints()
        {
            Console.WriteLine(" x: {0}, y: {1}", _x, _y);
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Inside Static method");
        }
    }
}
