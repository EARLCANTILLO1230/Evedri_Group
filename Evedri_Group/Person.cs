using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evedri_Group
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }

        public Person(string firstName, string lastName, int Age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = Age;
        }

    }
 }
