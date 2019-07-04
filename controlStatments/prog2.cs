using System;
namespace intro
{
    class prog2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the four digit number: ");
            string num1=Console.ReadLine();
            Console.Write("Enter the digit: ");
            string num2=Console.ReadLine();
            char[] ch=num2.ToCharArray();
            char[] c=num1.ToCharArray();
            if(c[0]==ch[0])
            {
                Console.Write(num2+" is in thousand's place");
            }
            else if(c[1]==ch[0])
            {
                Console.Write(num2+" is in Hundred's place");
            }
            else if(c[2]==ch[0])
            {
                Console.Write(num2+" is in Ten's place");
            }
            else if(c[3]==ch[0])
            {
                Console.Write(num2+" is in one's place");
            }
            
            
        }
    }
}