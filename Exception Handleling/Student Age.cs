using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handleling
{
    public class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {

        }
    }
    public class Student1
    {
        public string Name;
        public int Age;

        public void AcceptDetails(string Name, int Age)
        {
            if (Age < 18)
            {
                throw new AgeException("Age is not valid");
            }
            else
            {
                this.Name = Name;
                this.Age = Age;
            }
        }

    }


    }
