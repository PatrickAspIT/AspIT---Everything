using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_19
{
    class Person
    {
        // Opgave 19.3
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string secondName, int age)
        {
            FirstName = firstName;
            SecondName = secondName;
            Age = age;
        }
    }
}
