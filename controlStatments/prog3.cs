using System;
namespace intro
{
    class prog3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the charecter: ");
            string s=Console.ReadLine();
            char[] c=s.ToCharArray();
            if((c[0]>='A'&&c[0]<='Z')||(c[0]>='a'&&c[0]<='z'))
            {
                Console.Write(c[0]+" is a alphabet");
            }
            else if(c[0]>='0' && c[0]<='9')
            {
                 Console.Write(c[0]+" is a Numeric charecter");
            }
            else{
                 Console.Write("Enter the correct charecter");
            }
        }
    }
}    