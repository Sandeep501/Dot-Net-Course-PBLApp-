using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace excephandling
{
    class nameExcep
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your First Name: ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your Second Name: ");
                string lastName = Console.ReadLine();
                
                Regex reg = new Regex("^[a-zA-Z]+$");
                if((firstName==""||lastName=="")&(!reg.IsMatch(firstName))||(!reg.IsMatch(lastName)))
                {
                    throw new Invalidnameexception();
                }
                else
                {
                    Console.WriteLine("Your name has successfully registered in our servers as " + firstName + " " + lastName);
                }

            }
            catch(Invalidnameexception ex)
            {
                Console.WriteLine("Hint:\t");
                Console.Write("hey buddy! please do not leave the firstname and lastname blank and also check for invalid charecters in both the names :) ");

            }
            Console.ReadKey();
        }
    }

    [Serializable]
    internal class Invalidnameexception : Exception
    {
        public Invalidnameexception()
        {
            Console.WriteLine("exception caught please fill the names properly");
        }

       
    }
}
