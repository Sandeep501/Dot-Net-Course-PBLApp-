using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    class formateException

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the student name: ");
            string studentName = Console.ReadLine();
            try
            {
                Console.WriteLine("Please enter the student marks in Telugu: ");
                int telugu = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student marks in English: ");
                int english = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the student marks in Hindi: ");
                int hindi= Int32.Parse(Console.ReadLine());

                int sum = telugu + english + hindi;
                Console.WriteLine(studentName + " had scored " + sum + " out of " + 300);
                Console.ReadKey();

            }
            catch(FormatException e)
            {
                Console.WriteLine("You entered a non-integer value, please make sure to enter only int value");
                Console.ReadKey();
            }
               
            
        }
    }
}
