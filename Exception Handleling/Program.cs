using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handleling
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            try
            {
                student.AcceptDetails("", 20);
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("_____________________________");


            Student1 student1 = new Student1();
            try
            {
                student1.AcceptDetails("pankaj", 16);
            }
            catch ( AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        





    }
}





