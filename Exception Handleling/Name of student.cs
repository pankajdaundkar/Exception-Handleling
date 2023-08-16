using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handleling
{
        public class NameException : Exception
        {
            public NameException(string message) :base(message)
            {

            }
        }
        public class Student
        {
            public string Name;
            public int Age;

        public void AcceptDetails(string Name, int Age)
        {
            if(string.IsNullOrEmpty(Name))
            {
                throw new NameException("Name is required");
            }
            else
            {
                this.Name = Name;
                this.Age = Age;
            }
        }

        }
    }

