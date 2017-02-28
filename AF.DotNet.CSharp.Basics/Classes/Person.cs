using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Classes
{
    public class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public Person(string firstName = "", string lastName = "")
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Person(string firstName, string lastName, byte age) : this(firstName, lastName)
        {
            Age = age;
        }

        public override string ToString()
        {
            return string.Format("Name = {0} {1} ; Age = {2}", FirstName, LastName, Age);
        }
    }
}
