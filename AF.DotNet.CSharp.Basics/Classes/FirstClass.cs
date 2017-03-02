using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF.DotNet.CSharp.Basics.Classes
{
    public class FirstClass
    {
        public string myField = string.Empty;

        public FirstClass()
        {
        }

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}", parameter1, parameter2);
        }

        public int MyAutoImplementedProperty { get; set; }

        public string PropertyWithDefaultValue { get; set; } = "Default Name";

        private int _property1;
        public int Property1
        {
            get { return _property1; }
            set { _property1 = value; }
        }

        private int _property2;
        public int Property2
        {
            get
            {
                return _property2 / 2;
            }

            set
            {
                if (value > 100)
                    _property2 = 100;
                else
                    _property2 = value; ;
            }
        }
    }
}
