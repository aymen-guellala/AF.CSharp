using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Linq.Data
{
    class Student : IComparable<Student>
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (this.StudentName.Length >= other.StudentName.Length)
                return 1;

            return 0;
        }
    }

    class StudentNationaliy
    {
        public int StudentID { get; set; }
        public String Nationality { get; set; }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
                return true;
            else
                return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }

}
