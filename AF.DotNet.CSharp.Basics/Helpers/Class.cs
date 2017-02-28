using System;
using System.Collections.Generic;
using System.Text;

using AF.DotNet.CSharp.Basics.Classes;

namespace AF.DotNet.CSharp.Basics.Helpers
{
    class ClassHelper
    {
        public static void Run()
        {
            FirstClass myFirstClass = new FirstClass();
            myFirstClass.MyMethod(8, "Simple text dude ...");

            Line l1 = new Line();

            var student1 = new Student() { StudentID = 1, StudentName = "John" };
            var student2 = new Student() { StudentID = 2, StudentName = "Steve" };
            var student3 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student4 = new Student() { StudentID = 3, StudentName = "Bill" };
            var student5 = new Student() { StudentID = 5, StudentName = "Ron" };

            IList<Student> studentList_1 = new List<Student>() {
                                                    student1,
                                                    student2,
                                                    student3,
                                                    student4,
                                                    student5
                                                };

            IList<Student> studentList_2 = new List<Student>() {
                    new Student() { StudentID = 1, StudentName = "John"} ,
                    new Student() { StudentID = 2, StudentName = "Steve"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 3, StudentName = "Bill"} ,
                    new Student() { StudentID = 4, StudentName = "Ram" } ,
                    new Student() { StudentID = 5, StudentName = "Ron" }
                };

            IList<Student> studentList_3 = new List<Student>() {
                                    new Student() { StudentID = 1, StudentName = "John"} ,
                                    null
                                };


            Rectangle r = new Rectangle(4, 5);
            Triangle t = new Triangle(4, 8);
            Console.WriteLine("Rectangle and triangle have the some area : {0}", (r == t));
        }
    }
    
}
