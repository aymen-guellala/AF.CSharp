using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AF.DotNet.CSharp.Linq.Data;
using System.Collections;
using System.Linq.Expressions;

namespace AF.DotNet.CSharp.Linq
{
    class Program
    {
        public static Student[] studentArray = {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 },
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 19  },
                new Student() { StudentID = 8, StudentName = "Ben", Age = 18 },
                new Student() { StudentID = 9, StudentName = "Charles",  Age = 21 },
                new Student() { StudentID = 10, StudentName = "Andres",  Age = 35 },
                new Student() { StudentID = 11, StudentName = "Mohamed" , Age = 40 },
                new Student() { StudentID = 12, StudentName = "Aurelie" , Age = 22 },
                new Student() { StudentID = 13, StudentName = "Veronique",  Age = 33 },
                new Student() { StudentID = 14, StudentName = "Vincent",Age = 29  },
                new Student() { StudentID = 15, StudentName = "Quentin",Age = 26  },
                new Student() { StudentID = 16, StudentName = "Chris",  Age = 17 },

            };

        public static StudentNationaliy[] studentNationalityArray = {
                new StudentNationaliy() { StudentID = 1, Nationality = "USA"},
                new StudentNationaliy() { StudentID = 2, Nationality = "CAN"},
                new StudentNationaliy() { StudentID = 3, Nationality = "FRA"},
                new StudentNationaliy() { StudentID = 4, Nationality = "ALG"},
                new StudentNationaliy() { StudentID = 5, Nationality = "USA"},
                new StudentNationaliy() { StudentID = 6, Nationality = "CAN"},
                new StudentNationaliy() { StudentID = 7, Nationality = "FRA"},
                new StudentNationaliy() { StudentID = 8, Nationality = "CAN"},
                new StudentNationaliy() { StudentID = 9, Nationality = "CAN"},
                new StudentNationaliy() { StudentID = 10, Nationality = "ARG"},
                new StudentNationaliy() { StudentID = 11, Nationality = "TUN"},
                new StudentNationaliy() { StudentID = 12, Nationality = "FRA"},
                new StudentNationaliy() { StudentID = 13, Nationality = "CAN"},
                new StudentNationaliy() { StudentID = 14, Nationality = "FRA"},
                new StudentNationaliy() { StudentID = 15, Nationality = "FRA"},
            };

        public static IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five", "Six", "Seven" };
        public static IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };
        public static IList<string> strList2 = new List<string>() { "One", "Two", "Five", "Six" };

        static void Main(string[] args)
        {
            //Syntax();
            //Basics();
            //Join();
            //GroupBy();
            //Aggregate();
            //Defered_Immediate();

            Console.ReadKey();
        }

        public static void Syntax()
        {
            // LINQ Query Syntax to find out teenager students
            IEnumerable<Student> teenAgerStudent = from s in studentArray
                                                   where s.Age > 12 && s.Age < 20
                                                   orderby s.Age descending
                                                   select s;

            // LINQ Method Syntax to find out teenager students
            IEnumerable<Student> teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).OrderByDescending(s => s.Age);
        }

        public static void Basics()
        {
            // Select
            var selectResult = studentArray.Select(s => new { Name = s.StudentName, Age = s.Age });

            // First / FirstOrDefault / Last / LastOrDefault
            var firstResult = studentArray.Select(s => s.StudentName).FirstOrDefault(n => n.StartsWith("B"));

            // Average
            var avgAge = studentArray.Average(s => s.Age);

            // Count 
            var numOfStudents = studentArray.Count();

            // Max / Min
            var oldest = studentArray.Max(s => s.Age);
            var maxStudent = studentArray.Max(); // require implementation of IComparable<Student>

            // All / Any
            bool isAnyStudentTeenAger = studentArray.Any(s => s.Age > 12 && s.Age < 20);
            bool isAllStudentTeenAger = studentArray.All(s => s.Age > 12 && s.Age < 20);

            // Concat in C#
            var concatResult = strList1.Concat(strList2);

            // Except / Intersect / Union
            var exceptResult = strList1.Except(strList2);
            var intersectResult = strList1.Intersect(strList2);

            // Skip / SkipWhile / Take / TakeWhile
            var skipResult = strList.Skip(2);
            var skipWhileResult = strList.SkipWhile(s => s.Length < 4);
            var skipWhileIndexResult = strList.SkipWhile((s, i) => s.Length > i);

            // Empty / Range / Repeat
            var emptyCollection1 = Enumerable.Empty<string>();
            var emptyCollection2 = Enumerable.Empty<Student>();
            var intCollectionRange = Enumerable.Range(10, 10);
            var intCollectionRepeat = Enumerable.Repeat<int>(10, 3);
        }
        
        public static void Func_Action()
        {
            // Lamda expression assigned to Action delegate in C#
            Action<Student> PrintStudentDetail = s => Console.WriteLine("Name: {0}, Age: {1} ", s.StudentName, s.Age);
            PrintStudentDetail(studentArray[0]);//output: Name: Jhon, Age: 18

            // Lambda expression assigned to Func delegate in C#
            Func<Student, bool> isStudentTeenAger = s => s.Age > 12 && s.Age < 20;
            bool isTeen = isStudentTeenAger(studentArray[0]);// returns true


            // Func delegate in LINQ Method Syntax
            Func<Student, bool> is20sTeenAger = s => (s.Age / 10) == 2;
            var students20s = studentArray.Where(is20sTeenAger).ToList<Student>();

            // Func delegate in LINQ Query Syntax
            Func<Student, bool> is30sTeenAger = s => (s.Age / 10) == 3;
            var students30s = from s in studentArray
                              where isStudentTeenAger(s)
                              select s;

        }

        public static void Where()
        {
            // LINQ Method Syntax to find out teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.Age > 12 && s.Age < 20).OrderByDescending(s => s.Age).ToArray();

            // Where extension method also have second overload that includes index of current element in the collection
            var evenStudents = studentArray.Where((s, i) =>
            {
                if (i % 2 == 0) // if it is even element
                    return true;
                else
                    return false;
            });

        }

        public static void OfType()
        {
            // Mixed list
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            // OfType in C#
            var stringResult = mixedList.OfType<string>();
            var studentResult = mixedList.OfType<Student>();
        }

        public static void GroupBy()
        {
            var groupedResult = studentArray.Where(s => s.Age > 12 && s.Age < 20).GroupBy(s => s.Age);
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);  //Each group has a key 

                foreach (Student s in ageGroup)  //Each group has a inner collection  
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
        }

        public static void Join()
        {
            // Jointure on Method syntax
            var methodInnerJoin = studentArray.Join(// outer sequence 
                      studentNationalityArray,  // inner sequence 
                      student => student.StudentID,    // outerKeySelector
                      nationality => nationality.StudentID,  // innerKeySelector
                      (student, nationality) => new  // result selector
                      {
                          StudentName = student.StudentName,
                          StudentNationality = nationality.Nationality
                      });

            foreach (var s in methodInnerJoin)  //Each group has a inner collection  
                Console.WriteLine("Student Name: {0} , Nationality: {1}", s.StudentName, s.StudentNationality);


            // Jointure on Query syntax
            var queryInnerJoin = from s in studentArray // outer sequence
                                 join sn in studentNationalityArray //inner sequence 
                            on s.StudentID equals sn.StudentID // key selector 
                                 select new
                                 { // result selector 
                                     StudentName = s.StudentName,
                                     StudentNationality = sn.Nationality
                                 };

            // Detect duplicated object
            var duplicatedNames = studentArray.Join(// outer sequence 
                      studentArray,  // inner sequence 
                      sa1 => sa1.StudentName,    // outerKeySelector
                      sa2 => sa2.StudentName,  // innerKeySelector
                      (s1, s2) => new  // result selector
                      {
                          StudentName = s1.StudentName,
                          Duplicated = s1.StudentID != s2.StudentID
                      }).Where(s => s.Duplicated).Distinct();

            foreach (var s in duplicatedNames)
                Console.WriteLine("Student Name: {0} is repeated twice", s.StudentName);
        }
        
        public static void Contains()
        {
            // Mixed list
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });

            // Contains operator C#
            bool resultContains = mixedList.Contains(10);  // returns false
            bool studentsContains = studentArray.Contains(new Student { StudentID = 1, StudentName = "John" }, new StudentComparer());
        }

        public static void Aggregate()
        {
            // 1- Aggregate : Basic
            IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };
            var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(commaSeperatedString);

            // 2- Aggregate : Aggregate method with seed value in C#
            // Aggregate : The second overload method of Aggregate requires first parameter for seed value to accumulate. 
            string commaSeparatedStudentNames = studentArray.Aggregate<Student, string>(
                                        "Student Names: ",  // seed value
                                        (str, s) => str += s.StudentName + ",");

            Console.WriteLine(commaSeparatedStudentNames);
            
            int SumOfStudentsAge = studentArray.Aggregate<Student, int>(0, (totalAge, s) => totalAge += s.Age);


            // 3- Aggregate : Aggregate method with parameter of the Func delegate expression for result selector
            string commaSeparatedStudentNamesFormatted = studentArray.Aggregate<Student, string, string>(
                                            String.Empty, // seed value
                                            (str, s) => str += s.StudentName + ",", // returns result using seed value, String.Empty goes to lambda expression as str
                                            str => str.Substring(0, str.Length - 1)); // result selector that removes last comma

            Console.WriteLine(commaSeparatedStudentNamesFormatted);
        }
        
        public static void Defered_Immediate()
        {
            // Defered Linq // Immediate Linq
            IList<Student> studentsList = studentArray.ToList<Student>();

            IList<Student> teenAgerStudentsImmediate = studentsList.Where(s => s.Age > 12 && s.Age < 20).ToList();
            var teenAgerStudentsDefered = studentsList.Where(s => s.Age > 12 && s.Age < 20);

            Console.WriteLine("- Before Add :");
            foreach (var s in teenAgerStudentsImmediate)
                Console.WriteLine("Immediate results : Student Name: {0}", s.StudentName);
            foreach (var s in teenAgerStudentsDefered)
                Console.WriteLine("Defered results : Student Name: {0}", s.StudentName);

            studentsList.Add(new Student() { StudentName = "Moi", Age = 15 });

            Console.WriteLine("- After Add :");
            foreach (var s in teenAgerStudentsImmediate)
                Console.WriteLine("Immediate results : Student Name: {0}", s.StudentName);
            foreach (var s in teenAgerStudentsDefered)
                Console.WriteLine("Defered results : Student Name: {0}", s.StudentName);
        }

        public static void Expression()
        {
            // Expression
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;
            //compile Expression using Compile method to invoke it as Delegate
            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();
            //Invoke
            bool resultExpression = isTeenAger(new Student() { StudentID = 1, StudentName = "Steve", Age = 20 });

        }
        
    }
}
