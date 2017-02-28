using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Basics.Classes;
namespace AF.DotNet.CSharp.Basics.Helpers
{
    class InheritanceHelper
    {
        public static void Run()
        {
            Rectangle Rect = new Rectangle(5,7,10);
            int area;
            //Rect.setWidth(5);
            //Rect.setHeight(7);
            area = Rect.GetArea();

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.GetArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.GetCoast());
        }
    }    
}
